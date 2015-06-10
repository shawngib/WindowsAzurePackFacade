using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade.DataContracts
{
    [DataContract]
    public class WebSite
    {
        [DataMember(Name = "AdminEnabled")]
        [Display(Name = "AdminEnabled")]
        public bool AdminEnabled { get; set; }

        [DataMember(Name = "AvailabilityState")]
        [Display(Name = "Availability State")]
        public int? AvailabilityState { get; set; }

        [DataMember(Name = "Cers")]
        [Display(Name = "Cers")]
        public List<Cer> Cers { get; set; }

        [DataMember(Name = "ComputeMode")]
        [Display(Name = "Compute Mode")]
        public int? ComputeMode { get; set; }

        [DataMember(Name = "ContentAvailabilityState")]
        [Display(Name = "Content Availability State")]
        public int? ContentAvailabilityState { get; set; }

        [DataMember(Name = "Csrs")]
        [Display(Name = "Csrs")]
        public List<Csr> Csrs { get; set; }

        [DataMember(Name = "Enabled")]
        [Display(Name = "Enabled")]
        public bool Enabled { get; set; }

        [DataMember(Name = "EnabledHostNames")]
        [Display(Name = "Enabled Host Names")]
        public List<string> EnabledHostNames { get; set; }

        [DataMember(Name = "HostNameSslStates")]
        [Display(Name = "Host Name SSL States")]
        public List<HostNameSslState> HostNameSslStates { get; set; }

        [DataMember(Name = "HostNames")]
        [Display(Name = "Host Names")]
        public List<string> HostNames { get; set; }

        [DataMember(Name = "LastModifiedTimeUtc")]
        [Display(Name = "Last Modified Time Utc")]
        public DateTime LastModifiedTimeUtc { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Owner")]
        [Display(Name = "Owner")]
        public string Owner { get; set; }

        [DataMember(Name = "RepositorySiteName")]
        [Display(Name = "Repository Site Name")]
        public string RepositorySiteName { get; set; }

        [DataMember(Name = "RuntimeAvailabilityState")]
        [Display(Name = "Runtime Availability State")]
        public int? RuntimeAvailabilityState { get; set; }

        [DataMember(Name = "SSLCertificates")]
        [Display(Name = "SSL Certificates")]
        public List<SSLCertificate> SSLCertificates { get; set; }

        [DataMember(Name = "SelfLink")]
        [Display(Name = "SelfLink")]
        public string SelfLink { get; set; }

        [DataMember(Name = "ServerFarm")]
        [Display(Name = "Server Farm")]
        public string ServerFarm { get; set; }

        [DataMember(Name = "SiteMode")]
        [Display(Name = "Site Mode")]
        public string SiteMode { get; set; }

        [DataMember(Name = "SiteProperties")]
        [Display(Name = "Site Properties")]
        public SiteProperties SiteProperties { get; set; }

        [DataMember(Name = "State")]
        [Display(Name = "State")]
        public string State { get; set; }

        [DataMember(Name = "StorageRecoveryDefaultState")]
        [Display(Name = "Storage Recovery Default State")]
        public string StorageRecoveryDefaultState { get; set; }

        [DataMember(Name = "UsageState")]
        [Display(Name = "Usage State")]
        public int? UsageState { get; set; }

        [DataMember(Name = "WebSpace")]
        [Display(Name = "WebSpace")]
        public string WebSpace { get; set; }
    }

    public class Cer
    {
        public List<int> CerBlob { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string FriendlyName { get; set; }
        public List<string> HostNames { get; set; }
        public DateTime IssueDate { get; set; }
        public string Issuer { get; set; }
        public string Password { get; set; }
        public List<int> PfxBlob { get; set; }
        public string PublicKeyHash { get; set; }
        public string SelfLink { get; set; }
        public string SiteName { get; set; }
        public string SubjectName { get; set; }
        public string Thumbprint { get; set; }
        public bool ToDelete { get; set; }
        public bool Valid { get; set; }
    }

    public class Csr
    {
        public string CsrString { get; set; }
        public string DistinguishedName { get; set; }
        public List<string> HostNames { get; set; }
        public string Password { get; set; }
        public List<int> PfxBlob { get; set; }
        public string PublicKeyHash { get; set; }
        public string SelfLink { get; set; }
        public string SiteName { get; set; }
        public bool ToDelete { get; set; }
        public bool Valid { get; set; }
    }

    public class HostNameSslState
    {
        public string IpBasedSslResult { get; set; }
        public string Name { get; set; }
        public int SslState { get; set; }
        public string Thumbprint { get; set; }
        public bool ToUpdate { get; set; }
        public bool ToUpdateIpBasedSsl { get; set; }
        public string VirtualIP { get; set; }
    }

    public class SSLCertificate
    {
        public List<int> CerBlob { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string FriendlyName { get; set; }
        public List<string> HostNames { get; set; }
        public DateTime IssueDate { get; set; }
        public string Issuer { get; set; }
        public string Password { get; set; }
        public List<int> PfxBlob { get; set; }
        public string PublicKeyHash { get; set; }
        public string SelfLink { get; set; }
        public string SiteName { get; set; }
        public string SubjectName { get; set; }
        public string Thumbprint { get; set; }
        public bool ToDelete { get; set; }
        public bool Valid { get; set; }
    }

    public class AppSetting
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Metadata
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Property
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class SiteProperties
    {
        public List<AppSetting> AppSettings { get; set; }
        public List<Metadata> Metadata { get; set; }
        public List<Property> Properties { get; set; }
    }

    public class WebSiteList : List<WebSite>
    {
        /// <summary>
        /// Initializes a new instance of the Virtual Machine class.
        /// </summary>
        public WebSiteList()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualMachineList"/> class.
        /// </summary>
        /// <param name="records">The records.</param>
        public WebSiteList(IEnumerable<WebSite> records)
            : base(records)
        {
        }
    }

    [DataContract]
    public class WebSpace
    {

        [DataMember(Name = "AvailabilityState")]
        [Display(Name = "AvailabilityState")]
        public int? AvailabilityState { get; set; }

        [DataMember(Name = "ComputeMode")]
        [Display(Name = "ComputeMode")]
        public int? ComputeMode { get; set; }

        [DataMember(Name = "CurrentNumberOfWorkers")]
        [Display(Name = "CurrentNumberOfWorkers")]
        public int? CurrentNumberOfWorkers { get; set; }

        [DataMember(Name = "CurrentWorkerSize")]
        [Display(Name = "CurrentWorkerSize")]
        public object CurrentWorkerSize { get; set; }

        [DataMember(Name = "GeoLocation")]
        [Display(Name = "GeoLocation")]
        public object GeoLocation { get; set; }

        [DataMember(Name = "GeoRegion")]
        [Display(Name = "GeoRegion")]
        public string GeoRegion { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "NumberOfWorkers")]
        [Display(Name = "Number Of Workers")]
        public int NumberOfWorkers { get; set; }

        [DataMember(Name = "Plan")]
        [Display(Name = "Plan")]
        public string Plan { get; set; }

        [DataMember(Name = "Status")]
        [Display(Name = "Status")]
        public int Status { get; set; }

        [DataMember(Name = "Subscription")]
        [Display(Name = "Subscription")]
        public string Subscription { get; set; }

        [DataMember(Name = "WorkerSize")]
        [Display(Name = "Worker Size")]
        public object WorkerSize { get; set; }
    }
    
    public class WebSpaceList : List<WebSpace>
    {
        /// <summary>
        /// Initializes a new instance of the Virtual Machine class.
        /// </summary>
        public WebSpaceList()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualMachineList"/> class.
        /// </summary>
        /// <param name="records">The records.</param>
        public WebSpaceList(IEnumerable<WebSpace> records)
            : base(records)
        {
        }
    }
}
