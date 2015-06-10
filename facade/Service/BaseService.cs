using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Microsoft.Wap.Facade
{
    public class BaseService
    {
        protected HttpClient httpClient { get; set; }

        protected string mediaType { get; set; }
        
        public BaseService()
        {
            /// Bypasses certificate callback validation against, avoids comparing certificate name with host name
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(delegate { return true; });
        }

        public Uri CreateRequestUri(string relativePath, params KeyValuePair<string, string>[] queryStringParameters)
        {
            string queryString = string.Empty;

            if (queryStringParameters != null && queryStringParameters.Length > 0)
            {
                NameValueCollection queryStringProperties = System.Web.HttpUtility.ParseQueryString(httpClient.BaseAddress.Query);
                foreach (KeyValuePair<string, string> queryStringParameter in queryStringParameters)
                {
                    queryStringProperties[queryStringParameter.Key] = queryStringParameter.Value;
                }

                queryString = queryStringProperties.ToString();
            }

            return this.CreateRequestUri(relativePath, queryString);
        }

        protected Uri CreateRequestUri(string relativePath, string queryString)
        {
            var endpoint = new Uri(httpClient.BaseAddress, relativePath);
            var uriBuilder = new UriBuilder(endpoint) { Query = queryString };
            return uriBuilder.Uri;
        }

        public Task<T> GetAsync<T>(Uri requestUri, HttpMethod method, string userId = null)
        {
            var message = new HttpRequestMessage(method, requestUri);

            if (!string.IsNullOrWhiteSpace(userId))
            {
                message.Headers.Add("x-ms-principal-id", HttpUtility.UrlEncode(userId));
            }

            using (HttpResponseMessage response = this.httpClient.SendAsync(message).Result)
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Error Reading HTTP data...." + response.StatusCode);
                }

                return response.Content.ReadAsAsync<T>();
            }
        }

        public async Task<String> SendAsync(Uri requestUri, HttpMethod httpMethod, string body, string principalUserId = null, bool sendJSON = true)
        {
            HttpRequestMessage message = new HttpRequestMessage(httpMethod, requestUri);

            StringContent content = new StringContent(body);

            // Setup http headers
            if (!string.IsNullOrWhiteSpace(principalUserId))
            {
                message.Headers.Add("x-ms-principal-id", principalUserId);
            }

            // Setup the request message
            content.Headers.Remove("Content-Type");
            if (sendJSON)
            {
                mediaType = "application/json";
            }
            else
            {
                mediaType = "application/atom+xml";
            }
                content.Headers.Add("Content-Type", mediaType);

            message.Content = content;

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));

            // Call the service
            var response = await this.httpClient.SendAsync(message);

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

    }
}
