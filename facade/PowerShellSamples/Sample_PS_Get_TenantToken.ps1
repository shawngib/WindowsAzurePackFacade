function Get-TenantToken {

  param
  (
    [string]$authSiteAddress, # Auth site for Tenant ASP.NET
    [string]$UserName,
    [string]$Password, 
    [string]$clientRealm # for tenant ‘http://azureservices/TenantSite’
 )
# Uncomment if modules need to be loaded. You only need to load once per session.
#Add-Type -AssemblyName 'System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
#Add-Type -AssemblyName 'System.IdentityModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'

#region Get Tenant Token
# When not using Get-MgmtSvcToken commandlet from Service Management PowerShell this is the script required to get tokens for tenants

$identityProviderEndpoint = New-Object -TypeName System.ServiceModel.EndpointAddress -ArgumentList ($authSiteAddress + '/wstrust/issue/usernamemixed')
$identityProviderBinding = New-Object -TypeName System.ServiceModel.WS2007HttpBinding -ArgumentList ([System.ServiceModel.SecurityMode]::TransportWithMessageCredential)
$identityProviderBinding.Security.Message.EstablishSecurityContext = $false
$identityProviderBinding.Security.Message.ClientCredentialType = 'UserName'
$identityProviderBinding.Security.Transport.ClientCredentialType = 'None'

$trustChannelFactory = New-Object -TypeName System.ServiceModel.Security.WSTrustChannelFactory -ArgumentList $identityProviderBinding, $identityProviderEndpoint

if ($allowSelfSignCertificates)
{
    $certificateAuthentication = New-Object -TypeName System.ServiceModel.Security.X509ServiceCertificateAuthentication
    $certificateAuthentication.CertificateValidationMode = 'None'
    $trustChannelFactory.Credentials.ServiceCertificate.SslCertificateAuthentication = $certificateAuthentication
}

$trustChannelFactory.Credentials.SupportInteractive = $false
$trustChannelFactory.Credentials.UserName.UserName = $UserName
$trustChannelFactory.Credentials.UserName.Password = $Password

$channel = $trustChannelFactory.CreateChannel()
$rst = New-Object -TypeName System.IdentityModel.Protocols.WSTrust.RequestSecurityToken -ArgumentList ([System.IdentityModel.Protocols.WSTrust.RequestTypes]::Issue)
$rst.AppliesTo = New-Object -TypeName System.IdentityModel.Protocols.WSTrust.EndpointReference -ArgumentList $clientRealm
$rst.TokenType = 'urn:ietf:params:oauth:token-type:jwt'
$rst.KeyType = [System.IdentityModel.Protocols.WSTrust.KeyTypes]::Bearer
$rstr = New-Object -TypeName System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse
$token = $channel.Issue($rst, [ref] $rstr); 


$tokenString = ([System.IdentityModel.Tokens.GenericXmlSecurityToken]$token).TokenXml.InnerText;
$result = [System.Text.Encoding]::UTF8.GetString([System.Convert]::FromBase64String($tokenString));
return $result
#endregion
}