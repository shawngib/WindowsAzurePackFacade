using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Wap.Facade
{

    public enum LogonType
    {
        /// <summary>
        /// This logon type is intended for users who will be interactively using the computer, such as a user being logged on  
        /// by a terminal server, remote shell, or similar process.
        /// This logon type has the additional expense of caching logon information for disconnected operations; 
        /// therefore, it is inappropriate for some client/server applications,
        /// such as a mail server.
        /// </summary>
        LOGON32_LOGON_INTERACTIVE = 2,

        /// <summary>
        /// This logon type is intended for high performance servers to authenticate plaintext passwords.
        /// The LogonUser function does not cache credentials for this logon type.
        /// </summary>
        LOGON32_LOGON_NETWORK = 3,

        /// <summary>
        /// This logon type is intended for batch servers, where processes may be executing on behalf of a user without 
        /// their direct intervention. This type is also for higher performance servers that process many plaintext
        /// authentication attempts at a time, such as mail or Web servers. 
        /// The LogonUser function does not cache credentials for this logon type.
        /// </summary>
        LOGON32_LOGON_BATCH = 4,

        /// <summary>
        /// Indicates a service-type logon. The account provided must have the service privilege enabled. 
        /// </summary>
        LOGON32_LOGON_SERVICE = 5,

        /// <summary>
        /// This logon type is for GINA DLLs that log on users who will be interactively using the computer. 
        /// This logon type can generate a unique audit record that shows when the workstation was unlocked. 
        /// </summary>
        LOGON32_LOGON_UNLOCK = 7,

        /// <summary>
        /// This logon type preserves the name and password in the authentication package, which allows the server to make 
        /// connections to other network servers while impersonating the client. A server can accept plaintext credentials 
        /// from a client, call LogonUser, verify that the user can access the system across the network, and still 
        /// communicate with other servers.
        /// NOTE: Windows NT:  This value is not supported. 
        /// </summary>
        LOGON32_LOGON_NETWORK_CLEARTEXT = 8,

        /// <summary>
        /// This logon type allows the caller to clone its current token and specify new credentials for outbound connections.
        /// The new logon session has the same local identifier but uses different credentials for other network connections. 
        /// NOTE: This logon type is supported only by the LOGON32_PROVIDER_WINNT50 logon provider.
        /// NOTE: Windows NT:  This value is not supported. 
        /// </summary>
        LOGON32_LOGON_NEW_CREDENTIALS = 9,
    }

    public enum LogonProvider
    {
        /// <summary>
        /// Use the standard logon provider for the system. 
        /// The default security provider is negotiate, unless you pass NULL for the domain name and the user name 
        /// is not in UPN format. In this case, the default provider is NTLM. 
        /// NOTE: Windows 2000/NT:   The default security provider is NTLM.
        /// </summary>
        LOGON32_PROVIDER_DEFAULT = 0,

        /// <summary>
        /// Win NT 3.5
        /// </summary>
        LOGON32_PROVIDER_WINNT35 = 1,

        /// <summary>
        /// Win NT 4.0
        /// </summary>
        LOGON32_PROVIDER_WINNT40 = 2,

        /// <summary>
        /// Win NT 5.0
        /// </summary>
        LOGON32_PROVIDER_WINNT50 = 3
    }

    /// <summary>
    ///  Todo: Currently these are hard coded into this wrapper, I would reccomend moving to App Config settings files.
    /// </summary>
    public static class TenantApiUri
    {
        // Authentication Site URI's
        public const string WindowsAuthSite = "{0}/wstrust/issue/windowstransport";
        public const string AspNetAuthSite = "{0}/wstrust/issue/usernamemixed";

        //Common URI's with Tenant credentials
        // {0} = Base tenant API UR in form of https://server:port
        public const string Plans = "{0}/Plans";
        public const string Plan = Plans + "/{1}"; // {1} = Plan ID to retrieve individual plan
        public const string PlanMetrics = Plan + "metrics"; // Sample query string = ?startTime=2013-06-22T07%3a00%3a00.0000000Z&endTime=2013-06-29T07%3a00%3a00.0000000Z
        public const string Subscriptions = "{0}/Subscriptions";
        public const string Subscription = Subscriptions + "/Subscriptions/{1}"; // {1} = Subscription ID to retrieve individual subscription
        public const string AddOns = "{0}/Addons";
        public const string AddOn = AddOns + "/{1}";
        public const string Users = "{0}/users"; //  To get all users requires Admin API and Identity. CAN WE CREATE VIA TENANT API!
        public const string User = Users + "/{1}"; // Gets a specific user by ID against Tenant API (seems anyone can get anyone by ID).

        //IaaS URI's per subscription
        // {0} = Base tenant API URI in form of https://server:port/subscrptionID
        public const string UserRoles = "{0}/services/systemcenter/vmm/UserRoles";
        public const string UserRole = UserRoles + "/{1}";
        public const string ServiceClouds = "{0}/services/systemcenter/vmm/Clouds";
        public const string ServiceVirtualMachines = "{0}/services/systemcenter/vmm/VirtualMachines";
        public const string ServiceVirtualMachineActions = ServiceVirtualMachines + "(ID=guid'{1}',StampId=guid'{2}')";
        public const string ServiceVMNetworks = "{0}/services/systemcenter/vmm/VMNetworks";
        public const string VirtualHardDisks = "{0}/services/systemcenter/vmm/VirtualHardDisks";
        public const string VMTemplates = "{0}/services/systemcenter/vmm/VMTemplates";
        public const string VMTemplate = VMTemplates + "(ID=Guid'{1}',StampId=Guid'{2}')";

        // ToDo: Gallery Items have other content to use to add images to views in portal, for example: /Gallery/GalleryItems(Name%3d%27BlogEngineWG%27,Version%3d%271.0.0.1%27,Publisher%3d%27Microsoft%27)/Content?api-version=2013-03"
        public const string GalleryItems = "{0}/Gallery/GalleryItems?api-version=2013-03";
        public const string VMRoleGalleryItems = "{0}/Gallery/GalleryItems/$/MicrosoftCompute.VMRoleGalleryItem?api-version=2013-03";
        public const string GelleryItemReseourceDefinition =  "{0}/Gallery/GalleryItems(Name='{1}',Version='{2}',Publisher='{3}')/MicrosoftCompute.ResourceDefinitionGalleryItem/ResourceDefinition?api-version=2013-03"; //actually this is derifed in the above Gallery Item
        
        // VM Roles and Clouds Services
        public const string CloudServices = "{0}/CloudServices?api-version=2013-03";
        public const string VMRoleInstance = "{0}/CloudServices/{1}/Resources/MicrosoftCompute/VMRoles/{2}?api-version=2013-03";
        public const string ViewDefinition = "{0}/Gallery/ViewDefinitions{1}/%24value"; // Viewdefintiion link will actuall come from the VM ROle instance data itself
        
        // Databases as a service URI's
        public const string SqlDatabases = "{0}/services/sqlservers/databases";
        public const string SqlDatabase = "{0}/services/sqlservers/databases/{1}";
        public const string MySqlDatabases = "{0}/services/mysqlservers/databases";
        public const string MySqlDatabase = "{0}/services/mysqlservers/databases/{1}";

    }
}
