function Get-AdminToken {

  param
  (
    [string]$authSiteAddress, # Auth site for Windows Auth
    [string]$UserName,
    [string]$Password,
    [string]$Domain, 
    [string]$clientRealm # for admin use ‘http://azureservices/AdminSite’
 )
# Uncomment if modules need to be loaded. You only need to load once per session.
#Add-Type -AssemblyName 'System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
#Add-Type -AssemblyName 'System.IdentityModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'

#region Get Tenant Token
# When not using Get-MgmtSvcToken commandlet from Service Management PowerShell this is the script required to get tokensfor admins

$identityProviderEndpoint = New-Object -TypeName System.ServiceModel.EndpointAddress -ArgumentList ($authSiteAddress + '/wstrust/issue/windowstransport')
$identityProviderBinding = New-Object -TypeName System.ServiceModel.WS2007HttpBinding -ArgumentList ([System.ServiceModel.SecurityMode]::Transport)
$identityProviderBinding.Security.Message.EstablishSecurityContext = $false
$identityProviderBinding.Security.Message.ClientCredentialType = 'None'
$identityProviderBinding.Security.Transport.ClientCredentialType = 'Windows'

$trustChannelFactory = New-Object -TypeName System.ServiceModel.Security.WSTrustChannelFactory -ArgumentList $identityProviderBinding, $identityProviderEndpoint

if ($allowSelfSignCertificates)
{
    $certificateAuthentication = New-Object -TypeName System.ServiceModel.Security.X509ServiceCertificateAuthentication
    $certificateAuthentication.CertificateValidationMode = 'None'
    $trustChannelFactory.Credentials.ServiceCertificate.SslCertificateAuthentication = $certificateAuthentication
}

$Credential = New-Object System.Net.NetworkCredential -ArgumentList $UserName,$Password,$Domain 

$trustChannelFactory.TrustVersion = [System.ServiceModel.Security.TrustVersion]::WSTrust13 
$trustChannelFactory.Credentials.SupportInteractive = $false
$trustChannelFactory.Credentials.Windows.ClientCredential = $Credential 
$trustChannelFactory.Credentials.UserName.UserName = $UserName
$trustChannelFactory.Credentials.UserName.Password = $Password

$channel = $trustChannelFactory.CreateChannel()
$rst = New-Object -TypeName System.IdentityModel.Protocols.WSTrust.RequestSecurityToken -ArgumentList ([System.IdentityModel.Protocols.WSTrust.RequestTypes]::Issue)
$rst.AppliesTo = New-Object -TypeName System.IdentityModel.Protocols.WSTrust.EndpointReference -ArgumentList $clientRealm
$rst.KeyType = [System.IdentityModel.Protocols.WSTrust.KeyTypes]::Bearer
$rstr = New-Object -TypeName System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse
$token = $channel.Issue($rst, [ref] $rstr); 


$tokenString = ([System.IdentityModel.Tokens.GenericXmlSecurityToken]$token).TokenXml.InnerText;
$result = [System.Text.Encoding]::UTF8.GetString([System.Convert]::FromBase64String($tokenString));
return $result
#endregion
}