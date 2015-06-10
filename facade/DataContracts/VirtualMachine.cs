using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade
{
    [DataContract]
    public class VirtualMachine
    {
        [DataMember(Name = "ID")]
        [Display(Name = "ID")]
        public string ID { get; set; }

        [DataMember(Name = "StampId")]
        [Display(Name = "Stamp ID")]
        public string StampId { get; set; }

        [DataMember(Name = "AddedTime")]
        [Display(Name = "Added Time")]
        public DateTime AddedTime { get; set; }

        [DataMember(Name = "Agent")]
        [Display(Name = "Agent")]
        public bool? Agent { get; set; }

        [DataMember(Name = "AllocatedGPU")]
        [Display(Name = "Allocated GPU")]
        public string AllocatedGPU { get; set; }

        [DataMember(Name = "BackupEnabled")]
        [Display(Name = "Backup Enabled")]
        public bool? BackupEnabled { get; set; }

        [DataMember(Name = "BlockDynamicOptimization")]
        [Display(Name = "Block Dynamic Optimization")]
        public bool? BlockDynamicOptimization { get; set; }

        [DataMember(Name = "BlockLiveMigrationIfHostBusy")]
        [Display(Name = "Block Live Migration If Host Busy")]
        public bool? BlockLiveMigrationIfHostBusy { get; set; }

        [DataMember(Name = "CanVMConnect")]
        [Display(Name = "Can VM Connect")]
        public bool? CanVMConnect { get; set; }

        [DataMember(Name = "CapabilityProfile")]
        [Display(Name = "Capability Profile")]
        public string CapabilityProfile { get; set; }

        [DataMember(Name = "CheckpointLocation")]
        [Display(Name = "Checkpoint Location")]
        public string CheckpointLocation { get; set; }

        [DataMember(Name = "CloudId")]
        [Display(Name = "Cloud ID")]
        public string CloudId { get; set; }

        [DataMember(Name = "CloudVMRoleName")]
        [Display(Name = "Cloud VMRole Name")]
        public string CloudVMRoleName { get; set; }

        [DataMember(Name = "ComputerName")]
        [Display(Name = "Computer Name")]
        public string ComputerName { get; set; }

        [DataMember(Name = "ComputerTierId")]
        [Display(Name = "Computer Tier ID")]
        public string ComputerTierId { get; set; }

        [DataMember(Name = "CostCenter")]
        [Display(Name = "Cost Center")]
        public string CostCenter { get; set; }

        [DataMember(Name = "CPUCount")]
        [Display(Name = "CPU Count")]
        public Byte CPUCount { get; set; }

        [DataMember(Name = "CPULimitForMigration")]
        [Display(Name = "CPU Limit For Migration")]
        public bool? CPULimitForMigration { get; set; }

        [DataMember(Name = "CPULimitFunctionality")]
        [Display(Name = "CPU Limit Functionality")]
        public bool? CPULimitFunctionality { get; set; }

        [DataMember(Name = "CPUMax")]
        [Display(Name = "CPU Max")]
        public int? CPUMax { get; set; }

        [DataMember(Name = "CPURelativeWeight")]
        [Display(Name = "CPU Relative Weight")]
        public int? CPURelativeWeight { get; set; }

        [DataMember(Name = "CPUReserve")]
        [Display(Name = "CPU Reserve")]
        public int? CPUReserve { get; set; }

        [DataMember(Name = "CPUType")]
        [Display(Name = "CPU Type")]
        public string CPUType { get; set; }

        [DataMember(Name = "CPUUtilization")]
        [Display(Name = "CPU Utilization")]
        public int? CPUUtilization { get; set; }

        [DataMember(Name = "CreationSource")]
        [Display(Name = "Creation Source")]
        public string CreationSource { get; set; }

        [DataMember(Name = "CreationTime")]
        [Display(Name = "Creation Time")]
        public DateTime CreationTime { get; set; }

        [DataMember(Name = "DataExchangeEnabled")]
        [Display(Name = "Data Exchange Enabled")]
        public bool? DataExchangeEnabled { get; set; }

        [DataMember(Name = "DelayStart")]
        [Display(Name = "Delay Start")]
        public int? DelayStart { get; set; }

        [DataMember(Name = "DelayStartSeconds")]
        [Display(Name = "Delay Start Seconds")]
        public int? DelayStartSeconds { get; set; }

        [DataMember(Name = "DeploymentErrorInfo")]
        [Display(Name = "Deployment Error Info")]
        public DeploymentErrorInfo DeploymentErrorInfo { get; set; }

        [DataMember(Name = "DeployPath")]
        [Display(Name = "Deploy Path")]
        public string DeployPath { get; set; }

        [DataMember(Name = "Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "DiskIO")]
        [Display(Name = "Disk IO")]
        public int? DiskIO { get; set; }

        [DataMember(Name = "Dismiss")]
        [Display(Name = "Dismiss")]
        public bool? Dismiss { get; set; }

        [DataMember(Name = "Domain")]
        [Display(Name = "Domain")]
        public string Domain { get; set; }

        [DataMember(Name = "DynamicMemoryBufferPercentage")]
        [Display(Name = "Dynamic Memory Buffer Percentage")]
        public int? DynamicMemoryBufferPercentage { get; set; }

        [DataMember(Name = "DynamicMemoryDemandMB")]
        [Display(Name = "Dynamic Memory Demand MB")]
        public int? DynamicMemoryDemandMB { get; set; }

        [DataMember(Name = "DynamicMemoryEnabled")]
        [Display(Name = "Dynamic Memory Enabled")]
        public bool? DynamicMemoryEnabled { get; set; }

        [DataMember(Name = "DynamicMemoryMaximumMB")]
        [Display(Name = "Dynamic Memory Maximum MB")]
        public int? DynamicMemoryMaximumMB { get; set; }

        [DataMember(Name = "Enabled")]
        [Display(Name = "Enabled")]
        public bool? Enabled { get; set; }

        [DataMember(Name = "ExcludeFromPRO")]
        [Display(Name = "Exclude From PRO")]
        public bool? ExcludeFromPRO { get; set; }

        [DataMember(Name = "ExpectedCPUUtilization")]
        [Display(Name = "Expected CPU Utilization")]
        public int? ExpectedCPUUtilization { get; set; }

        [DataMember(Name = "FailedJobID")]
        [Display(Name = "Failed Job ID")]
        public string FailedJobID { get; set; }

        [DataMember(Name = "FullName")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [DataMember(Name = "Generation")]
        [Display(Name = "Generation")]
        public int? Generation { get; set; }

        [DataMember(Name = "GrantedToList")]
        [Display(Name = "Granted To List")]
        public List<GrantedToList> GrantedToList { get; set; }

        [DataMember(Name = "HardwareProfileId")]
        [Display(Name = "Hardware Profile ID")]
        public string HardwareProfileId { get; set; }

        [DataMember(Name = "HasPassthroughDisk")]
        [Display(Name = "Has Passthrough Disk")]
        public bool? HasPassthroughDisk { get; set; }

        [DataMember(Name = "HasSavedState")]
        [Display(Name = "Has Saved State")]
        public bool? HasSavedState { get; set; }

        [DataMember(Name = "HasVMAdditions")]
        [Display(Name = "Has VM Additions")]
        public bool? HasVMAdditions { get; set; }

        [DataMember(Name = "HeartbeatEnabled")]
        [Display(Name = "HeartbeatEnabled")]
        public bool? HeartbeatEnabled { get; set; }

        [DataMember(Name = "HighlyAvailable")]
        [Display(Name = "Highly Available")]
        public bool? HighlyAvailable { get; set; }

        [DataMember(Name = "IsRecoveryVM")]
        [Display(Name = "Is Recovery VM")]
        public bool? IsRecoveryVM { get; set; }

        [DataMember(Name = "IsUndergoingLiveMigration")]
        [Display(Name = "Is Undergoing Live Migration")]
        public bool? IsUndergoingLiveMigration { get; set; }

        [DataMember(Name = "LastRestoredCheckpointId")]
        [Display(Name = "Last Restored Checkpoint ID")]
        public string LastRestoredCheckpointId { get; set; }

        [DataMember(Name = "LibraryGroup")]
        [Display(Name = "Library Group")]
        public string LibraryGroup { get; set; }

        [DataMember(Name = "LimitCPUForMigration")]
        [Display(Name = "Limit CPU For Migration")]
        public bool? LimitCPUForMigration { get; set; }

        [DataMember(Name = "LimitCPUFunctionality")]
        [Display(Name = "Limit CPU Functionality")]
        public bool? LimitCPUFunctionality { get; set; }

        [DataMember(Name = "LinuxAdministratorSSHKey")]
        [Display(Name = "Linux Administrator SSHKey")]
        public string LinuxAdministratorSSHKey { get; set; }

        [DataMember(Name = "LinuxAdministratorSSHKeyString")]
        [Display(Name = "Linux Administrator SSHKey String")]
        public string LinuxAdministratorSSHKeyString { get; set; }

        [DataMember(Name = "LinuxDomainName")]
        [Display(Name = "Linux Domain Name")]
        public string LinuxDomainName { get; set; }

        [DataMember(Name = "LocalAdminPassword")]
        [Display(Name = "Local Admin Password")]
        public string LocalAdminPassword { get; set; }

        [DataMember(Name = "LocalAdminRunAsAccountName")]
        [Display(Name = "Local Admin RunAs Account Name")]
        public string LocalAdminRunAsAccountName { get; set; }

        [DataMember(Name = "LocalAdminUserName")]
        [Display(Name = "Local Admin User Name")]
        public string LocalAdminUserName { get; set; }

        [DataMember(Name = "Location")]
        [Display(Name = "Location")]
        public string Location { get; set; }

        [DataMember(Name = "MarkedAsTemplate")]
        [Display(Name = "Marked As Template")]
        public bool? MarkedAsTemplate { get; set; }

        [DataMember(Name = "Memory")]
        [Display(Name = "Memory")]
        public int? Memory { get; set; }

        [DataMember(Name = "MemoryAssignedMB")]
        [Display(Name = "Memory Assigned MB")]
        public int? MemoryAssignedMB { get; set; }

        [DataMember(Name = "MemoryAvailablePercentage")]
        [Display(Name = "Memory Available Percentage")]
        public int? MemoryAvailablePercentage { get; set; }

        [DataMember(Name = "MemoryWeight")]
        [Display(Name = "Memory Weight")]
        public int? MemoryWeight { get; set; }

        [DataMember(Name = "ModifiedTime")]
        [Display(Name = "Modified Time")]
        public DateTime ModifiedTime { get; set; }

        [DataMember(Name = "MostRecentTaskId")]
        [Display(Name = "MostRecent Task ID")]
        public string MostRecentTaskId { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "NetworkUtilization")]
        [Display(Name = "Network Utilization")]
        public int? NetworkUtilization { get; set; }

        [DataMember(Name = "NewVirtualNetworkAdapterInput")]
        [JsonProperty(PropertyName = "NewVirtualNetworkAdapterInput")]
        [Display(Name = "New Virtual Network Adapter Input")]
        public List<object> NewVirtualNetworkAdapterInput { get; set; }

        [DataMember(Name = "NumLock")]
        [Display(Name = "Num Lock")]
        public bool? NumLock { get; set; }

        [DataMember(Name = "OperatingSystem")]
        [Display(Name = "OperatingSystem")]
        public string OperatingSystem { get; set; }

        [DataMember(Name = "OperatingSystemInstance")]
        [Display(Name = "Operating System Instance")]
        public OperatingSystemInstance OperatingSystemInstance { get; set; }

        [DataMember(Name = "OperatingSystemShutdownEnabled")]
        [Display(Name = "OperatingSystemShutdownEnabled")]
        public string OperatingSystemShutdownEnabled { get; set; }

        [DataMember(Name = "Operation")]
        [Display(Name = "Operation")]
        public string Operation { get; set; }

        [DataMember(Name = "OrganizationName")]
        [Display(Name = "OrganizationName")]
        public string OrganizationName { get; set; }

        [DataMember(Name = "Owner")]
        [Display(Name = "Owner")]
        public Owner Owner { get; set; }

        [DataMember(Name = "Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataMember(Name = "Path")]
        [Display(Name = "Path")]
        public string Path { get; set; }

        [DataMember(Name = "PerfCPUUtilization")]
        [Display(Name = "Perf CPU Utilization")]
        public int? PerfCPUUtilization { get; set; }

        [DataMember(Name = "PerfDiskBytesRead")]
        [Display(Name = "Perf Disk Bytes Read")]
        public int? PerfDiskBytesRead { get; set; }

        [DataMember(Name = "PerfDiskBytesWrite")]
        [Display(Name = "Perf Disk Bytes Write")]
        public int? PerfDiskBytesWrite { get; set; }

        [DataMember(Name = "PerfNetworkBytesRead")]
        [Display(Name = "Perf Network Bytes Read")]
        public int? PerfNetworkBytesRead { get; set; }

        [DataMember(Name = "PerfNetworkBytesWrite")]
        [Display(Name = "Perf Network Bytes Write")]
        public int? PerfNetworkBytesWrite { get; set; }

        [DataMember(Name = "ProductKey")]
        [Display(Name = "Product Key")]
        public string ProductKey { get; set; }

        [DataMember(Name = "Retry")]
        [Display(Name = "Retry")]
        public bool? Retry { get; set; }

        [DataMember(Name = "RunAsAccountUserName")]
        [Display(Name = "RunAs Account UserName")]
        public string RunAsAccountUserName { get; set; }

        [DataMember(Name = "RunGuestAccount")]
        [Display(Name = "Run Guest Account")]
        public string RunGuestAccount { get; set; }

        [DataMember(Name = "ServiceDeploymentErrorMessage")]
        [Display(Name = "Service Deployment Error Message")]
        public string ServiceDeploymentErrorMessage { get; set; }

        [DataMember(Name = "ServiceId")]
        [Display(Name = "Service ID")]
        public string ServiceId { get; set; }

        [DataMember(Name = "SharePath")]
        [Display(Name = "Share Path")]
        public string SharePath { get; set; }

        [DataMember(Name = "SourceObjectType")]
        [Display(Name = "Source Object Type")]
        public string SourceObjectType { get; set; }

        [DataMember(Name = "StartAction")]
        [Display(Name = "Start Action")]
        public string StartAction { get; set; }

        [DataMember(Name = "StartVM")]
        [Display(Name = "Start VM")]
        public string StartVM { get; set; }

        [DataMember(Name = "Status")]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [DataMember(Name = "StatusString")]
        [Display(Name = "Status String")]
        public string StatusString { get; set; }

        [DataMember(Name = "StopAction")]
        [Display(Name = "Stop Action")]
        public string StopAction { get; set; }

        [DataMember(Name = "Tag")]
        [Display(Name = "Tag")]
        public string Tag { get; set; }

        [DataMember(Name = "TimeSynchronizationEnabled")]
        [Display(Name = "Time Synchronization Enabled")]
        public bool? TimeSynchronizationEnabled { get; set; }

        [DataMember(Name = "TimeZone")]
        [Display(Name = "TimeZone")]
        public int? TimeZone { get; set; }

        [DataMember(Name = "TotalSize")]
        [Display(Name = "Total Size")]
        public Int64 TotalSize { get; set; }

        [DataMember(Name = "Undo")]
        [Display(Name = "Undo")]
        public bool? Undo { get; set; }

        [DataMember(Name = "UndoDisksEnabled")]
        [Display(Name = "Undo Disks Enabled")]
        public bool? UndoDisksEnabled { get; set; }

        [DataMember(Name = "UpgradeDomain")]
        [Display(Name = "Upgrade Domain")]
        public int? UpgradeDomain { get; set; }

        [DataMember(Name = "UseCluster")]
        [Display(Name = "Use Cluster")]
        public string UseCluster { get; set; }

        [DataMember(Name = "UseLAN")]
        [Display(Name = "Use LAN")]
        public string UseLAN { get; set; }

        [DataMember(Name = "UserName")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [DataMember(Name = "VirtualHardDiskId")]
        [Display(Name = "Virtual Hard Disk ID")]
        public string VirtualHardDiskId { get; set; }

        [DataMember(Name = "VirtualizationPlatform")]
        [Display(Name = "Virtualization Platform")]
        public string VirtualizationPlatform { get; set; }

        [DataMember(Name = "VirtualMachineState")]
        [Display(Name = "Virtual Machine State")]
        public string VirtualMachineState { get; set; }

        [DataMember(Name = "VMBaseConfigurationId")]
        [Display(Name = "VM Base Configuration ID")]
        public string VMBaseConfigurationId { get; set; }

        [DataMember(Name = "VMConfigResource")]
        [Display(Name = "VM Config Resource")]
        public string VMConfigResource { get; set; }

        [DataMember(Name = "VMConnection")]
        [Display(Name = "VM Connection")]
        public string VMConnection { get; set; }

        [DataMember(Name = "VMCPath")]
        [Display(Name = "VMC Path")]
        public string VMCPath { get; set; }

        [DataMember(Name = "VMHostName")]
        [Display(Name = "VM Host Name")]
        public string VMHostName { get; set; }

        [DataMember(Name = "VMId")]
        [Display(Name = "VM ID")]
        public string VMId { get; set; }

        [DataMember(Name = "VMNetworkAssignments")]
        [JsonProperty(PropertyName = "VMNetworkAssignments")]
        [Display(Name = "VM Network Assignments")]
        public List<Object> VMNetworkAssignments { get; set; }

        [DataMember(Name = "VMResource")]
        [Display(Name = "VM Resource")]
        public string VMResource { get; set; }

        [DataMember(Name = "VMResourceGroup")]
        [Display(Name = "VM Resource Group")]
        public string VMResourceGroup { get; set; }

        [DataMember(Name = "VMTemplateId")]
        [Display(Name = "VM Template ID")]
        public string VMTemplateId { get; set; }

        [DataMember(Name = "WorkGroup")]
        [Display(Name = "Work Group")]
        public string WorkGroup { get; set; }
    }

    public class DeploymentErrorInfo
    {
        public string CloudProblem { get; set; }
        public string Code { get; set; }
        public string DetailedCode { get; set; }
        public string DetailedErrorCode { get; set; }
        public string DetailedSource { get; set; }
        public string DisplayableErrorCode { get; set; }
        public string ErrorCodeString { get; set; }
        public string ErrorType { get; set; }
        public string ExceptionDetails { get; set; }
        public string IsConditionallyTerminating { get; set; }
        public string IsDeploymentBlocker { get; set; }
        public string IsMomAlert { get; set; }
        public string IsSuccess { get; set; }
        public string IsTerminating { get; set; }
        public string MessageParameters { get; set; }
        public string MomAlertSeverity { get; set; }
        public string Problem { get; set; }
        public string RecommendedAction { get; set; }
        public string RecommendedActionCLI { get; set; }
        public string ShowDetailedError { get; set; }
    }

    public class Owner
    {
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public string RoleID { get; set; }
    }

    public class GrantedToList
    {
        public object UserName { get; set; }
        public string RoleName { get; set; }
        public string RoleID { get; set; }
    }

    [JsonArrayAttribute]
    public class NewVMVirtualNetworkAdapterInput
    {
        [Display(Name = "IPv4AddressType")]
        public string IPv4AddressType { get; set; }

        [Display(Name = "IPv6 Address Type")]
        public string IPv6AddressType { get; set; }

        [Display(Name = "MAC Address")]
        public string MACAddress { get; set; }

        [Display(Name = "MAC Address Type")]
        public string MACAddressType { get; set; }

        [Display(Name = "VLan Enabled")]
        public string VLanEnabled { get; set; }

        [Display(Name = "VLan ID")]
        public int? VLanId { get; set; }

        [Display(Name = "VM Network Name")]
        public string VMNetworkName { get; set; }
    }

    public class OperatingSystemInstance
    {
        [Display(Name = "Architecture")]
        public string Architecture { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Edition")]
        public string Edition { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "OS Type")]
        public string OSType { get; set; }

        [Display(Name = "Product Type")]
        public string ProductType { get; set; }

        [Display(Name = "Version")]
        public string Version { get; set; }
    }

    [JsonArrayAttribute]
    public class VMNetworkAssignment
    {
        [Display(Name = "Virtual Network Adapter ID")]
        public string VirtualNetworkAdapterID { get; set; }

        [Display(Name = "VM Network Name")]
        public string VMNetworkName { get; set; }
    }

    public class VirtualMachineList : List<VirtualMachine>
    {
        public VirtualMachineList()
            : base()
        {
        }

        public VirtualMachineList(IEnumerable<VirtualMachine> records)
            : base(records)
        {
        }
    }

}
