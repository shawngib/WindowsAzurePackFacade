using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade
{
    [DataContract]
    public class UserRoles
    {
        [DataMember(Name = "AddMember")]
        [Display(Name = "Add Member")]
        public List<object> AddMember { get; set; }

        [DataMember(Name = "AddResource")]
        [Display(Name = "Add Resource")]
        public List<object> AddResource { get; set; }

        [DataMember(Name = "AddScope")]
        [Display(Name = "Add Scope")]
        public List<object> AddScope { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public List<object> AddCloudResourceExtension { get; set; }

        [DataMember(Name = "Description")]
        [Display(Name = "Description")]
        public object Description { get; set; }

        [DataMember(Name = "ID")]
        [Display(Name = "ID")]
        public string ID { get; set; }

        [DataMember(Name = "Members")]
        [Display(Name = "Members")]
        public List<object> Members { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "ParentUserRoleId")]
        [Display(Name = "ParentUserRoleId")]
        public object ParentUserRoleId { get; set; }

        [DataMember(Name = "Permission")]
        [Display(Name = "Permission")]
        public List<string> Permission { get; set; }

        [DataMember(Name = "CloudPermission")]
        [Display(Name = "CloudPermission")]
        public List<object> CloudPermission { get; set; }

        [DataMember(Name = "Profile")]
        [Display(Name = "Profile")]
        public string Profile { get; set; }

        [DataMember(Name = "Quotas")]
        [Display(Name = "Quotas")]
        public List<Quota> Quotas { get; set; }

        [DataMember(Name = "RemoveMember")]
        [Display(Name = "RemoveMember")]
        public List<object> RemoveMember { get; set; }

        [DataMember(Name = "UserRoleProfile")]
        [Display(Name = "UserRoleProfile")]
        public object UserRoleProfile { get; set; }

        [DataMember(Name = "PermissionInput")]
        [Display(Name = "PermissionInput")]
        public List<object> PermissionInput { get; set; }

        [DataMember(Name = "CloudPermissionInput")]
        [Display(Name = "CloudPermissionInput")]
        public List<object> CloudPermissionInput { get; set; }

        [DataMember(Name = "RemoveResource")]
        [Display(Name = "RemoveResource")]
        public List<object> RemoveResource { get; set; }

        [DataMember(Name = "RemoveScope")]
        [Display(Name = "RemoveScope")]
        public List<object> RemoveScope { get; set; }

        [DataMember(Name = "RemoveCloudResourceExtension")]
        [Display(Name = "RemoveCloudResourceExtension")]
        public List<object> RemoveCloudResourceExtension { get; set; }

        [DataMember(Name = "VMId")]
        [Display(Name = "VMId")]
        public object VMId { get; set; }

        [DataMember(Name = "VMTemplateId")]
        [Display(Name = "VMTemplateId")]
        public object VMTemplateId { get; set; }

        [DataMember(Name = "UserRoleDataPath")]
        [Display(Name = "UserRoleDataPath")]
        public List<object> UserRoleDataPath { get; set; }

        [DataMember(Name = "VMNetworkQuota")]
        [Display(Name = "VMNetworkQuota")]
        public List<VMNetworkQuota> VMNetworkQuota { get; set; }
    }
    public class Quota
    {
        public string Scope { get; set; }
        public object StampId { get; set; }
        public string ScopeType { get; set; }
        public int RoleCPUCount { get; set; }
        public int RoleMemoryMB { get; set; }
        public int RoleStorageGB { get; set; }
        public object RoleCustomQuotaCount { get; set; }
        public object RoleVMCount { get; set; }
        public int MemberCPUCount { get; set; }
        public int MemberMemoryMB { get; set; }
        public int MemberStorageGB { get; set; }
        public object MemberCustomQuotaCount { get; set; }
        public object MemberVMCount { get; set; }
    }

    public class VMNetworkQuota
    {
        public object StampId { get; set; }
        public object VMNetworkMaximum { get; set; }
        public object VMNetworkMaximumPerUser { get; set; }
        public int VPNConnectionMaximum { get; set; }
        public int VPNConnectionMaximumPerUser { get; set; }
        public object VMNetworkVPNMaximumBandwidthInKbps { get; set; }
        public object VMNetworkVPNMaximumBandwidthOutKbps { get; set; }
        public object RemoveVMNetworkMaximum { get; set; }
        public object RemoveVMNetworkMaximumPerUser { get; set; }
        public object RemoveVPNConnectionMaximum { get; set; }
        public object RemoveVPNConnectionMaximumPerUser { get; set; }
        public object RemoveVMNetworkVPNMaximumBandwidthIn { get; set; }
        public object RemoveVMNetworkVPNMaximumBandwidthOut { get; set; }
    }

}
