# Gerneral variables used for testing samples
$WAPserver = "WAP01" # Wap Server name (if express install was used and all API's and authentication sites are on same server, if not change them in the respective variables below)
$Domain = "contoso.com" # Only used when getting admin token
$UserName = "shawngib@microsoft.com"
$Password = "Pass@word1"
$UserAuthSite = "https://" + $WAPserver + ":30071"  # Tenant ASP.NET 'AuthSite' use port 30072 for admin authentication
$TenantAPIEndpoint = "https://" + $WAPserver + ":30005" # Non-Public URL for tenant API
$TemplateName = "WS2012D" # Used to get template ID for creating VM based on Template example
$ClientRealm = "http://azureservices/TenantSite" # Used to get authentication token
$name = "SamplesAgain" # Used to name a VM that is getting deployed

###############################################################################
#
# Take note in each Invoke Restmethod we may just return 'Value'.
# For some admin requests like get all users you would return 'Items'
#
###############################################################################

#region Hides Certificate Validation when using self-signed certs
        add-type @"
            using System.Net;
            using System.Security.Cryptography.X509Certificates;
            public class TrustAllCertsPolicy : ICertificatePolicy {
                public bool CheckValidationResult(
                    ServicePoint srvPoint, X509Certificate certificate,
                    WebRequest request, int certificateProblem) {
                    return true;
                }
            }
"@
        [System.Net.ServicePointManager]::CertificatePolicy = New-Object TrustAllCertsPolicy  -ErrorAction SilentlyContinue
#endregion

    Add-Type -AssemblyName 'System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
    Add-Type -AssemblyName 'System.IdentityModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'

# The following line uses the Get-TenantToken function. You can use dot notation to include the Sample_PS_Get_TenantToken file or pre run that fucntion 
$token = Get-TenantToken -UserName $UserName -Password $Password -clientRealm $ClientRealm -authSiteAddress $UserAuthSite
# Uncomment the following and use the additional file Sample_PS_Get_AdminToken file
# Get-AdminToken -UserName $UserName -Password $Password -Domain $Domain -clientRealm $ClientRealm -authSiteAddress $UserAuthSite 

# This creates the base header for with the tenant API's
$Headers = @{Authorization = "Bearer $token"
    "Accept" = "application/json" 
    "x-ms-principal-id" = $UserName
     } 

# Build on the Tenant API endpoint to create a URI for requesting all available subscriptions to a user
$FullUriSubscriptions = $TenantAPIEndpoint + "/subscriptions" 

#Actually make the calls to the web service with the headers and URI for subscriptions
$Subscriptions = (Invoke-RestMethod -Uri $FullUriSubscriptions -ContentType "application/json" -Headers $Headers -Method Get -Debug -Verbose)

# Build a URI to get Clouds that the tenant can publish to. Clouds are a one to one realtaionship to plans, plans + tenant equals a subscription
# In this URI we use the above results for subscriptions which can be an array of many subscriptions and use the first one's ID to create the URI
$FullUriClouds = $TenantAPIEndpoint + "/" + $Subscriptions[0].SubscriptionID + "/services/systemcenter/vmm/Clouds"

# Makes the API call to get clouds for the first subscription in the array that could be included from the subscriptions request.
# Key to note that this and mny other calls will provide an return value that includes 2 keys and we need the information in the 'value' key (unlike get subscriptions)
$clouds = (Invoke-RestMethod -Uri $FullUriClouds -ContentType "application/json" -Headers $Headers -Method Get -Debug -Verbose).value

#Build URI to get Gallery Items
$FullUriGalleryItems = $TenantAPIEndpoint + "/" + $Subscriptions[0].SubscriptionID + "/Gallery/GalleryItems?api-version=2013-03"

# Gets all gallery items including VM Roles
$GalleryItems = (Invoke-RestMethod -Uri $FullUriGalleryItems -ContentType "application/json" -Headers $Headers -Method Get -Debug -Verbose).value
# The following is a sample query string which when appended to the full URL of requesting VMs or VM templates will include details of the Network adapters, SCSI Adapters, Hard Disks and other drives.
# its inlcuded this way to shotcut escaping caharacters and makes for a quick way to show sample queryoes. 
$QueryStringForStaticPoolRequest = @'
?$expand=VirtualNetworkAdapters,VirtualSCSIAdapters,VirtualHardDisks,VirtualDiskDrives
'@
# Builds the URI to make the call to get all VM's for the first subscription in the array of gathered subscriptions
$FullUriVM = $TenantAPIEndpoint + "/" + $Subscriptions[0].SubscriptionID + "/services/systemcenter/vmm/VirtualMachines" +$QueryStringForStaticPoolRequest

$vms = (Invoke-RestMethod -Uri $FullUriVM -ContentType "application/json" -Headers $Headers -Method Get -Debug -Verbose).value

# Builds the URI to make the call to get all VM Templates for the first subscription in the array of gathered subscriptions
$FullUriVMTemplates = $TenantAPIEndpoint + "/" + $Subscriptions[0].SubscriptionID + "/services/systemcenter/vmm/VMTemplates"
$vmTemplates = (Invoke-RestMethod -Uri $FullUriVMTemplates -ContentType "application/json" -Headers $Headers -Method Get -Debug -Verbose).value

# Here we filter down the ersults to a Template by name ################## Be sure to change the name to what you want in the general varaibles above
$VMTemplate = $vmTemplates | Where-Object {$_.Name -eq $TemplateName} 

# To take action against a VM like start, stop or shutdown you need to create a small JSON object to reqpresent the operation and ID you want to accomplich and use the merge method.
$Action = "Start" # Set as what ever operation you wish. Start, Stop, Shutdown, Restart and others
$Now = Get-Date -Format s # Creates a current timestamp to attach to the operation
#region JSON Payload for operating against a VM - Check pointing is different
        $JSONPayloadToOperate =[ordered]@{} 
            $JSONPayloadToOperate.'odata.type' = "VMM.VirtualMachine"
            $JSONPayloadToOperate.ModifiedTime = $Now
            $JSONPayloadToOperate.Operation = $Action
            $JsonToOperate = $JSONPayloadToOperate | ConvertTo-Json -Depth 3
#endregion
$FullUriVM = $TenantAPIEndpoint + "/" + $Subscriptions[0].SubscriptionID + "/services/systemcenter/vmm/VirtualMachines"
# Now we create the URI for the operation which is the same as getting VM's plus a little filter on the end with VM ID and Stamp ID
$FullUriMerge = $FullUriVM + "(ID=guid'" + $vms[0].ID +"',StampId=guid'"+ $vms[0].StampId +"')"

# Operate against the Vm using the following web request as a merge method
Invoke-RestMethod -Uri $FullUriMerge -ContentType "application/json" -Body $JsonToOperate -Headers $Headers -Method Merge -Debug -Verbose

# To create a VM we need to create a JSON representation of a VM. First we create VM Object with properties in PowerShell then convert to 3 layer JSON
#region JSON Payload for creating virtual machine
        $JSONPayload =[ordered]@{} 
        $JSONPayload.AddedTime = $null
        $JSONPayload.Agent = $null
        $JSONPayload.AllocatedGPU = $null
        $JSONPayload.BackupEnabled = $null
        $JSONPayload.BlockDynamicOptimization = $null
        $JSONPayload.BlockLiveMigrationIfHostBusy = $null
        $JSONPayload.CPUCount = $null
        $JSONPayload.CPULimitForMigration = $null
        $JSONPayload.CPULimitFunctionality = $null
        $JSONPayload.CPUMax = $null
        $JSONPayload.CPURelativeWeight = $null
        $JSONPayload.CPUReserve = $null
        $JSONPayload.CPUType = $null
        $JSONPayload.CPUUtilization = $null
        $JSONPayload.CanVMConnect = $null
        $JSONPayload.CapabilityProfile = $null
        $JSONPayload.CheckpointLocation = $null
        $JSONPayload.CloudId = $clouds[0].ID ################################################################# Required field derived from gathered clouds above and using first one in array
        $JSONPayload.CloudVMRoleName = $null
        $JSONPayload.ComputerName = $null
        $JSONPayload.ComputerTierId = $null
        $JSONPayload.CostCenter = $null
        $JSONPayload.CreationSource = $null
        $JSONPayload.CreationTime = $null
        $JSONPayload.DataExchangeEnabled = $null
        $JSONPayload.DelayStart = $null
        $JSONPayload.DelayStartSeconds = $null
        $JSONPayload.DeployPath = $null
        $JSONPayload.DeploymentErrorInfo = @()
            $DeploymentErrorInfo = [ordered]@{} 
            $DeploymentErrorInfo.CloudProblem = $null
            $DeploymentErrorInfo.Code = $null
            $DeploymentErrorInfo.DetailedCode = $null
            $DeploymentErrorInfo.DetailedErrorCode = $null
            $DeploymentErrorInfo.DetailedSource = $null
            $DeploymentErrorInfo.DisplayableErrorCode = $null
            $DeploymentErrorInfo.ErrorCodeString = $null
            $DeploymentErrorInfo.ErrorType = $null
            $DeploymentErrorInfo.ExceptionDetails = $null
            $DeploymentErrorInfo.IsConditionallyTerminating = $null
            $DeploymentErrorInfo.IsDeploymentBlocker = $null
            $DeploymentErrorInfo.IsMomAlert = $null
            $DeploymentErrorInfo.IsSuccess = $null
            $DeploymentErrorInfo.IsTerminating = $null
            $DeploymentErrorInfo.MessageParameters = $null
            $DeploymentErrorInfo.MomAlertSeverity = $null
            $DeploymentErrorInfo.Problem = $null
            $DeploymentErrorInfo.RecommendedAction = $null
            $DeploymentErrorInfo.RecommendedActionCLI = $null
            $DeploymentErrorInfo.ShowDetailedError = $null
            $DeploymentErrorInfo.'odata.type' = "VMM.ErrorInfo"
        $JSONPayload.DeploymentErrorInfo = $DeploymentErrorInfo
        $JSONPayload.Description = $null
        $JSONPayload.DiskIO = $null
        $JSONPayload.Dismiss = $null
        $JSONPayload.Domain = $null
        $JSONPayload.DynamicMemoryBufferPercentage = $null
        $JSONPayload.DynamicMemoryDemandMB = $null
        $JSONPayload.DynamicMemoryEnabled = $null
        $JSONPayload.DynamicMemoryMaximumMB = $null
        $JSONPayload.Enabled = $null
        $JSONPayload.ExcludeFromPRO = $null
        $JSONPayload.ExpectedCPUUtilization = $null
        $JSONPayload.FailedJobID = $null
        $JSONPayload.FullName = $null
        $JSONPayload.Generation = $null
        $JSONPayload.GrantedToList = @()
        $JSONPayload.'GrantedToList@odata.type' = "Collection(VMM.UserAndRole)"
        $JSONPayload.HardwareProfileId = $null
        $JSONPayload.HasPassthroughDisk = $null
        $JSONPayload.HasSavedState = $null
        $JSONPayload.HasVMAdditions = $null
        $JSONPayload.HeartbeatEnabled = $null
        $JSONPayload.HighlyAvailable = $null
        $JSONPayload.ID = "00000000-0000-0000-0000-000000000000"  #################################### ID is required to be all zeros to deploy new VM
        $JSONPayload.IsFaultTolerant = $null
        $JSONPayload.IsHighlyAvailable = $null
        $JSONPayload.IsRecoveryVM = $null
        $JSONPayload.IsUndergoingLiveMigration = $null
        $JSONPayload.LastRestoredCheckpointId = $null
        $JSONPayload.LibraryGroup = $null
        $JSONPayload.LimitCPUForMigration = $null
        $JSONPayload.LimitCPUFunctionality = $null
        $JSONPayload.LinuxAdministratorSSHKey = $null
        $JSONPayload.LinuxAdministratorSSHKeyString = $null
        $JSONPayload.LinuxDomainName = $null
        $JSONPayload.LocalAdminPassword = $null
        $JSONPayload.LocalAdminRunAsAccountName = $null
        $JSONPayload.LocalAdminUserName = $null
        $JSONPayload.Location = $null
        $JSONPayload.MarkedAsTemplate = $null
        $JSONPayload.Memory = $null
        $JSONPayload.MemoryAssignedMB = $null
        $JSONPayload.MemoryAvailablePercentage = $null
        $JSONPayload.MemoryWeight = $null
        $JSONPayload.ModifiedTime = $null
        $JSONPayload.MostRecentTaskId = $null
        $JSONPayload.Name = $name            ################################################################################# Name needs to be supplied 
        $JSONPayload.NetworkUtilization = $null
        $JSONPayload.NewVirtualNetworkAdapterInput = @()
        $JSONPayload.'NewVirtualNetworkAdapterInput@odata.type' = "Collection(VMM.NewVMVirtualNetworkAdapterInput)"
        $JSONPayload.NumLock = $null
        $JSONPayload.OperatingSystem = $null
        $JSONPayload.OperatingSystemInstance = @()
            $OperatingSystemInstance = [ordered]@{}
            $OperatingSystemInstance.Architecture = $null
            $OperatingSystemInstance.Description = $null
            $OperatingSystemInstance.Edition = $null
            $OperatingSystemInstance.Name = $null
            $OperatingSystemInstance.OSType = $null
            $OperatingSystemInstance.ProductType = $null
            $OperatingSystemInstance.Version = $null
            $OperatingSystemInstance.'odata.type' = "VMM.OperatingSystem"
            $JSONPayload.OperatingSystemInstance = $OperatingSystemInstance
        $JSONPayload.OperatingSystemShutdownEnabled = $null
        $JSONPayload.Operation = $null
        $JSONPayload.OrganizationName = $null
        $JSONPayload.Owner = @()
            $Owner = [ordered]@{}
            $Owner.RoleID = $OwnerRoleID
            $Owner.RoleName = $OwnerRoleName
            $Owner.UserName = $OwnerUserName
            $Owner.'odata.type' = "VMM.UserAndRole"
            $JSONPayload.Owner = $Owner
        $JSONPayload.Password = $null
        $JSONPayload.Path = $null
        $JSONPayload.PerfCPUUtilization = $null
        $JSONPayload.PerfDiskBytesRead = $null
        $JSONPayload.PerfDiskBytesWrite = $null
        $JSONPayload.PerfNetworkBytesRead = $null
        $JSONPayload.PerfNetworkBytesWrite = $null
        $JSONPayload.ProductKey = $null
        $JSONPayload.Retry = $null
        $JSONPayload.RunAsAccountUserName = $null
        $JSONPayload.RunGuestAccount = $null
        $JSONPayload.ServiceDeploymentErrorMessage = $null
        $JSONPayload.ServiceId = $null
        $JSONPayload.SharePath = $null
        $JSONPayload.SourceObjectType = $null
        $JSONPayload.StampId = $clouds[0].StampID ################################################################# Required field derived from gathered clouds above and using first one in array
        $JSONPayload.StartAction = $null
        $JSONPayload.StartVM = $true
        $JSONPayload.Status = $null
        $JSONPayload.StatusString = $null
        $JSONPayload.StopAction = $null
        $JSONPayload.Tag = $null
        $JSONPayload.TimeSynchronizationEnabled = $null
        $JSONPayload.TimeZone = $null
        $JSONPayload.TotalSize = $null
        $JSONPayload.Undo = $null
        $JSONPayload.UndoDisksEnabled = $null
        $JSONPayload.UpgradeDomain = $null
        $JSONPayload.UseCluster = $null
        $JSONPayload.UseLAN = $null
        $JSONPayload.UserName = $null
        $JSONPayload.VMBaseConfigurationId = $null
        $JSONPayload.VMCPath = $null
        $JSONPayload.VMConfigResource = $null
        $JSONPayload.VMHostName = $null
        $JSONPayload.VMId = $null
        $JSONPayload.VMNetworkAssignments = @()
        $JSONPayload.'VMNetworkAssignments@odata.type' = "Collection(VMM.VMNetworkAssignment)"
        $JSONPayload.VMResource = $null
        $JSONPayload.VMResourceGroup = $null
        $JSONPayload.VMTemplateId = $VMTemplate.ID ##################################################### Required Value derived from filtering down array of templates gather by name
        $JSONPayload.VirtualHardDiskId = $null
        $JSONPayload.VirtualMachineState = $null
        $JSONPayload.VirtualizationPlatform = $null
        $JSONPayload.WorkGroup = $null
        $JSONPayload.'odata.type' = "VMM.VirtualMachine"
        #endregion
        $payload = $JSONPayload | ConvertTo-Json -Depth 3

# the Deploy VM requires uses the same API URI as the get VM's but uses a POST method and the VM JSON we created above as the body
$result = (Invoke-RestMethod -Uri $FullUriVM -Body $payload -ContentType "application/json" -Headers $Headers -Method Post -Debug -Verbose)
