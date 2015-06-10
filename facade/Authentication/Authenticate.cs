using System;
using System.IdentityModel.Protocols.WSTrust;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;

namespace Microsoft.Wap.Facade.Authentication
{
    public class Authenticate
    {
        public string GetTenantToken(string authSiteEndPoint, string userName, string password, bool validateCertificate, string realm)
        {
            var identityProviderEndpoint = new EndpointAddress(new Uri(authSiteEndPoint + TenantApiUri.AspNetAuthSite));

            var identityProviderBinding = new WS2007HttpBinding(SecurityMode.TransportWithMessageCredential);
            identityProviderBinding.Security.Message.EstablishSecurityContext = false;
            identityProviderBinding.Security.Message.ClientCredentialType = MessageCredentialType.UserName;
            identityProviderBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;

            var trustChannelFactory = new WSTrustChannelFactory(identityProviderBinding, identityProviderEndpoint)
            {
                TrustVersion = TrustVersion.WSTrust13,
            };

            if (!validateCertificate)
            {
                trustChannelFactory.Credentials.ServiceCertificate.SslCertificateAuthentication = new X509ServiceCertificateAuthentication() { CertificateValidationMode = X509CertificateValidationMode.None };
            }
            trustChannelFactory.Credentials.SupportInteractive = false;
            trustChannelFactory.Credentials.UserName.UserName = userName;
            trustChannelFactory.Credentials.UserName.Password = password;

            var channel = trustChannelFactory.CreateChannel();
            var rst = new RequestSecurityToken(RequestTypes.Issue)
            {
                AppliesTo = new EndpointReference(realm),
                TokenType = "urn:ietf:params:oauth:token-type:jwt",
                KeyType = KeyTypes.Bearer,
            };

            RequestSecurityTokenResponse rstr = null;
            SecurityToken token = null;

            token = channel.Issue(rst, out rstr);
            var tokenString = (token as GenericXmlSecurityToken).TokenXml.InnerText;
            var jwtString = Encoding.UTF8.GetString(Convert.FromBase64String(tokenString));

            return jwtString;
        }

        public string GetWindowsAuthToken(string windowsAuthSiteEndpoint, string domainName, string userName, string password, string realm)
        {
            string token = null;
            Inpersonation.Impersonate(domainName, userName, password, () => token = GetWindowsToken(windowsAuthSiteEndpoint, realm));
            return token;
        }

        private static string GetWindowsToken(string windowsAuthSiteEndPoint, string realm)
        {
            var identityProviderEndpoint = new EndpointAddress(new Uri(windowsAuthSiteEndPoint + TenantApiUri.WindowsAuthSite));
            var identityProviderBinding = new WS2007HttpBinding(SecurityMode.Transport);
            identityProviderBinding.Security.Message.EstablishSecurityContext = false;
            identityProviderBinding.Security.Message.ClientCredentialType = MessageCredentialType.None;
            identityProviderBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;

            var trustChannelFactory = new WSTrustChannelFactory(identityProviderBinding, identityProviderEndpoint)
            {
                TrustVersion = TrustVersion.WSTrust13,
            };

            trustChannelFactory.Credentials.ServiceCertificate.SslCertificateAuthentication = new X509ServiceCertificateAuthentication() { CertificateValidationMode = X509CertificateValidationMode.None };
            var channel = trustChannelFactory.CreateChannel();

            var rst = new RequestSecurityToken(RequestTypes.Issue)
            {
                AppliesTo = new EndpointReference(realm),
                KeyType = KeyTypes.Bearer,
            };

            RequestSecurityTokenResponse rstr = null;
            SecurityToken token = null;

            token = channel.Issue(rst, out rstr);
            var tokenString = (token as GenericXmlSecurityToken).TokenXml.InnerText;
            var jwtString = Encoding.UTF8.GetString(Convert.FromBase64String(tokenString));

            return jwtString;
        }
    }
}
