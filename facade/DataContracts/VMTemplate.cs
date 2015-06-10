using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade.DataContracts
{
    [DataContract]
    public class VMTemplate
    {

        [DataMember(Name = "StampId")]
        [Display(Name = "StampId")]
        public string StampId { get; set; }

        [DataMember(Name = "ID")]
        [Display(Name = "ID")]
        public string ID { get; set; }

        [DataMember(Name = "AccessedTime")]
        [Display(Name = "AccessedTime")]
        public object AccessedTime { get; set; }

        [DataMember(Name = "AddedTime")]
        [Display(Name = "AddedTime")]
        public string AddedTime { get; set; }

        [DataMember(Name = "Admin")]
        [Display(Name = "Admin")]
        public string Admin { get; set; }

        [DataMember(Name = "AdminPasswordHasValue")]
        [Display(Name = "AdminPasswordHasValue")]
        public bool? AdminPasswordHasValue { get; set; }

        [DataMember(Name = "ComputerName")]
        [Display(Name = "ComputerName")]
        public string ComputerName { get; set; }

        [DataMember(Name = "CPUCount")]
        [Display(Name = "CPUCount")]
        public int? CPUCount { get; set; }

        [DataMember(Name = "CPUMax")]
        [Display(Name = "CPUMax")]
        public int? CPUMax { get; set; }

        [DataMember(Name = "CPUReserve")]
        [Display(Name = "CPUReserve")]
        public int? CPUReserve { get; set; }

        [DataMember(Name = "CPUType")]
        [Display(Name = "CPUType")]
        public string CPUType { get; set; }

        [DataMember(Name = "CreationTime")]
        [Display(Name = "CreationTime")]
        public string CreationTime { get; set; }

        [DataMember(Name = "DiskIO")]
        [Display(Name = "DiskIO")]
        public int? DiskIO { get; set; }

        [DataMember(Name = "DomainAdmin")]
        [Display(Name = "DomainAdmin")]
        public string DomainAdmin { get; set; }

        [DataMember(Name = "DomainAdminPasswordHasValue")]
        [Display(Name = "DomainAdminPasswordHasValue")]
        public bool? DomainAdminPasswordHasValue { get; set; }

        [DataMember(Name = "ExpectedCPUUtilization")]
        [Display(Name = "ExpectedCPUUtilization")]
        public int? ExpectedCPUUtilization { get; set; }

        [DataMember(Name = "Enabled")]
        [Display(Name = "Enabled")]
        public bool? Enabled { get; set; }

        [DataMember(Name = "FullName")]
        [Display(Name = "FullName")]
        public string FullName { get; set; }

        [DataMember(Name = "HasVMAdditions")]
        [Display(Name = "HasVMAdditions")]
        public bool? HasVMAdditions { get; set; }

        [DataMember(Name = "IsHighlyAvailable")]
        [Display(Name = "IsHighlyAvailable")]
        public bool? IsHighlyAvailable { get; set; }

        [DataMember(Name = "JoinDomain")]
        [Display(Name = "JoinDomain")]
        public string JoinDomain { get; set; }

        [DataMember(Name = "JoinWorkgroup")]
        [Display(Name = "JoinWorkgroup")]
        public object JoinWorkgroup { get; set; }

        [DataMember(Name = "LibraryGroup")]
        [Display(Name = "LibraryGroup")]
        public string LibraryGroup { get; set; }

        [DataMember(Name = "LimitCPUForMigration")]
        [Display(Name = "LimitCPUForMigration")]
        public bool? LimitCPUForMigration { get; set; }

        [DataMember(Name = "LimitCPUFunctionality")]
        [Display(Name = "LimitCPUFunctionality")]
        public bool? LimitCPUFunctionality { get; set; }

        [DataMember(Name = "Location")]
        [Display(Name = "Location")]
        public string Location { get; set; }

        [DataMember(Name = "Memory")]
        [Display(Name = "Memory")]
        public int? Memory { get; set; }

        [DataMember(Name = "MergeAnswerFile")]
        [Display(Name = "MergeAnswerFile")]
        public bool? MergeAnswerFile { get; set; }

        [DataMember(Name = "ModifiedTime")]
        [Display(Name = "ModifiedTime")]
        public string ModifiedTime { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "NetworkUtilization")]
        [Display(Name = "NetworkUtilization")]
        public int? NetworkUtilization { get; set; }

        [DataMember(Name = "OperatingSystem")]
        [Display(Name = "OperatingSystem")]
        public string OperatingSystem { get; set; }
        public OperatingSystemInstance OperatingSystemInstance { get; set; }

        [DataMember(Name = "OSType")]
        [Display(Name = "OSType")]
        public string OSType { get; set; }

        [DataMember(Name = "OrgName")]
        [Display(Name = "OrgName")]
        public string OrgName { get; set; }
        public Owner Owner { get; set; }

        [DataMember(Name = "GrantedToList")]
        [Display(Name = "GrantedToList")]
        public List<GrantedToList> GrantedToList { get; set; }

        [DataMember(Name = "QuotaPoint")]
        [Display(Name = "QuotaPoint")]
        public int? QuotaPoint { get; set; }

        [DataMember(Name = "ProductKeyHasValue")]
        [Display(Name = "ProductKeyHasValue")]
        public bool? ProductKeyHasValue { get; set; }

        [DataMember(Name = "RelativeWeight")]
        [Display(Name = "RelativeWeight")]
        public int? RelativeWeight { get; set; }

        [DataMember(Name = "ShareSCSIBus")]
        [Display(Name = "ShareSCSIBus")]
        public bool? ShareSCSIBus { get; set; }

        [DataMember(Name = "Tag")]
        [Display(Name = "Tag")]
        public string Tag { get; set; }

        [DataMember(Name = "TimeZone")]
        [Display(Name = "TimeZone")]
        public int? TimeZone { get; set; }

        [DataMember(Name = "TotalVHDCapacity")]
        [Display(Name = "TotalVHDCapacity")]
        public string TotalVHDCapacity { get; set; }

        [DataMember(Name = "UndoDisksEnabled")]
        [Display(Name = "UndoDisksEnabled")]
        public bool? UndoDisksEnabled { get; set; }

        [DataMember(Name = "UseHardwareAssistedVirtualization")]
        [Display(Name = "UseHardwareAssistedVirtualization")]
        public bool? UseHardwareAssistedVirtualization { get; set; }

        [DataMember(Name = "Accessibility")]
        [Display(Name = "Accessibility")]
        public string Accessibility { get; set; }

        [DataMember(Name = "CostCenter")]
        [Display(Name = "CostCenter")]
        public object CostCenter { get; set; }

        [DataMember(Name = "Description")]
        [Display(Name = "Description")]
        public object Description { get; set; }

        [DataMember(Name = "IsTagEmpty")]
        [Display(Name = "IsTagEmpty")]
        public bool? IsTagEmpty { get; set; }

        [DataMember(Name = "NicCount")]
        [Display(Name = "NicCount")]
        public int? NicCount { get; set; }

        [DataMember(Name = "NumLockEnabled")]
        [Display(Name = "NumLockEnabled")]
        public bool? NumLockEnabled { get; set; }

        [DataMember(Name = "VMAddition")]
        [Display(Name = "VMAddition")]
        public string VMAddition { get; set; }

        [DataMember(Name = "IsCustomizable")]
        [Display(Name = "IsCustomizable")]
        public bool? IsCustomizable { get; set; }

        [DataMember(Name = "DomainAdminPasswordIsServiceSetting")]
        [Display(Name = "DomainAdminPasswordIsServiceSetting")]
        public bool? DomainAdminPasswordIsServiceSetting { get; set; }

        [DataMember(Name = "SANCopyCapable")]
        [Display(Name = "SANCopyCapable")]
        public bool? SANCopyCapable { get; set; }

        [DataMember(Name = "IsTemporaryTemplate")]
        [Display(Name = "IsTemporaryTemplate")]
        public bool? IsTemporaryTemplate { get; set; }

        [DataMember(Name = "VMTemplateId")]
        [Display(Name = "VMTemplateId")]
        public object VMTemplateId { get; set; }

        [DataMember(Name = "VirtualHardDiskId")]
        [Display(Name = "VirtualHardDiskId")]
        public object VirtualHardDiskId { get; set; }

        [DataMember(Name = "VMId")]
        [Display(Name = "VMId")]
        public object VMId { get; set; }

        [DataMember(Name = "SharePath")]
        [Display(Name = "SharePath")]
        public object SharePath { get; set; }

        [DataMember(Name = "ApplicationProfileId")]
        [Display(Name = "ApplicationProfileId")]
        public object ApplicationProfileId { get; set; }

        [DataMember(Name = "CloudID")]
        [Display(Name = "CloudID")]
        public object CloudID { get; set; }

        [DataMember(Name = "DynamicMemoryBufferPercentage")]
        [Display(Name = "DynamicMemoryBufferPercentage")]
        public object DynamicMemoryBufferPercentage { get; set; }

        [DataMember(Name = "DynamicMemoryEnabled")]
        [Display(Name = "DynamicMemoryEnabled")]
        public bool? DynamicMemoryEnabled { get; set; }

        [DataMember(Name = "DynamicMemoryMaximumMB")]
        [Display(Name = "DynamicMemoryMaximumMB")]
        public object DynamicMemoryMaximumMB { get; set; }

        [DataMember(Name = "MemoryWeight")]
        [Display(Name = "MemoryWeight")]
        public int? MemoryWeight { get; set; }

        [DataMember(Name = "DynamicMemoryPreferredBufferPercentage")]
        [Display(Name = "DynamicMemoryPreferredBufferPercentage")]
        public object DynamicMemoryPreferredBufferPercentage { get; set; }

        [DataMember(Name = "SQLProfileId")]
        [Display(Name = "SQLProfileId")]
        public object SQLProfileId { get; set; }

        [DataMember(Name = "VirtualFloppyDriveId")]
        [Display(Name = "VirtualFloppyDriveId")]
        public object VirtualFloppyDriveId { get; set; }

        [DataMember(Name = "BootOrder")]
        [Display(Name = "BootOrder")]
        public List<string> BootOrder { get; set; }

        [DataMember(Name = "CustomProperties")]
        [Display(Name = "CustomProperties")]
        public List<string> CustomProperties { get; set; }

        [DataMember(Name = "GuiRunOnceCommands")]
        [Display(Name = "GuiRunOnceCommands")]
        public List<object> GuiRunOnceCommands { get; set; }

        [DataMember(Name = "ServerFeatures")]
        [Display(Name = "ServerFeatures")]
        public List<object> ServerFeatures { get; set; }

        [DataMember(Name = "Status")]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [DataMember(Name = "VirtualizationPlatform")]
        [Display(Name = "VirtualizationPlatform")]
        public string VirtualizationPlatform { get; set; }

        [DataMember(Name = "CapabilityProfile")]
        [Display(Name = "CapabilityProfile")]
        public object CapabilityProfile { get; set; }

        [DataMember(Name = "AutoLogonCount")]
        [Display(Name = "AutoLogonCount")]
        public object AutoLogonCount { get; set; }

        [DataMember(Name = "DomainJoinOrganizationalUnit")]
        [Display(Name = "DomainJoinOrganizationalUnit")]
        public object DomainJoinOrganizationalUnit { get; set; }

        [DataMember(Name = "SANStatus")]
        [Display(Name = "SANStatus")]
        public List<object> SANStatus { get; set; }

        [DataMember(Name = "Generation")]
        [Display(Name = "Generation")]
        public int? Generation { get; set; }
    }

    public class OperatingSystemInstance
    {
        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "Version")]
        [Display(Name = "Version")]
        public string Version { get; set; }

        [DataMember(Name = "Architecture")]
        [Display(Name = "Architecture")]
        public string Architecture { get; set; }

        [DataMember(Name = "Edition")]
        [Display(Name = "Edition")]
        public string Edition { get; set; }

        [DataMember(Name = "OSType")]
        [Display(Name = "OSType")]
        public string OSType { get; set; }

        [DataMember(Name = "ProductType")]
        [Display(Name = "ProductType")]
        public string ProductType { get; set; }
    }

    public class Owner
    {

        [DataMember(Name = "UserName")]
        [Display(Name = "UserName")]
        public object UserName { get; set; }

        [DataMember(Name = "RoleName")]
        [Display(Name = "RoleName")]
        public object RoleName { get; set; }

        [DataMember(Name = "RoleID")]
        [Display(Name = "RoleID")]
        public object RoleID { get; set; }
    }

    public class GrantedToList
    {

        [DataMember(Name = "UserName")]
        [Display(Name = "UserName")]
        public object UserName { get; set; }

        [DataMember(Name = "RoleName")]
        [Display(Name = "RoleName")]
        public string RoleName { get; set; }

        [DataMember(Name = "RoleID")]
        [Display(Name = "RoleID")]
        public string RoleID { get; set; }
    }

    public class VMTemplateList : List<VMTemplate>
    {
        public VMTemplateList()
            : base()
        {
        }

        public VMTemplateList(IEnumerable<VMTemplate> records)
            : base(records)
        {
        }
    }
}
