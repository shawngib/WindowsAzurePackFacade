using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;

namespace Microsoft.Wap.Facade
{
    class Helper
    {
        protected HttpClient httpClient { get; set; }
        protected string mediaType { get; set; }

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

    }
}
