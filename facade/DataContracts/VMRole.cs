using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade.DataContracts
{
    [DataContract]
    public class CloudService
    {
        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Label")]
        [Display(Name = "Label")]
        public string Label { get; set; }

        [DataMember(Name = "ProvisioningState")]
        [Display(Name = "ProvisioningState")]
        public string ProvisioningState { get; set; }
    }

    public class CloudServiceList : List<CloudService>
    {
        public CloudServiceList()
            : base()
        {
        }

        public CloudServiceList(IEnumerable<CloudService> records)
            : base(records)
        {
        }
    }

    [DataContract]
    public class VMRoleInstance
    {
        [DataMember(Name = "InstanceView")]
        [Display(Name = "InstanceView")]
        public object InstanceView { get; set; }

        [DataMember(Name = "Label")]
        [Display(Name = "Label")]
        public string Label { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "ProvisioningState")]
        [Display(Name = "ProvisioningState")]
        public object ProvisioningState { get; set; }

        [DataMember(Name = "ResourceConfiguration")]
        [Display(Name = "ResourceConfiguration")]
        public ResourceConfiguration ResourceConfiguration { get; set; }

        [DataMember(Name = "ResourceDefinition")]
        [Display(Name = "ResourceDefinition")]
        public ResourceDefinition ResourceDefinition { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public object Substate { get; set; }
    }

    [DataContract]
    public class ResourceDefinition
    {
        [DataMember(Name = "IntrinsicSettings")]
        [Display(Name = "IntrinsicSettings")]
        public IntrinsicSettings IntrinsicSettings { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Publisher")]
        [Display(Name = "Publisher")]
        public string Publisher { get; set; }

        [DataMember(Name = "ResourceExtensionReferences")]
        [Display(Name = "ResourceExtensionReferences")]
        public List<ResourceExtensionReference> ResourceExtensionReferences { get; set; }

        [DataMember(Name = "ResourceParameters")]
        [Display(Name = "ResourceParameters")]
        public List<ResourceParameter> ResourceParameters { get; set; }

        [DataMember(Name = "SchemaVersion")]
        [Display(Name = "SchemaVersion")]
        public string SchemaVersion { get; set; }

        [DataMember(Name = "Type")]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [DataMember(Name = "Version")]
        [Display(Name = "Version")]
        public string Version { get; set; }
    }

    public class ResourceConfiguration
    {
        [DataMember(Name = "ParameterValues")]
        [Display(Name = "ParameterValues")]
        public string ParameterValues { get; set; }

        [DataMember(Name = "Version")]
        [Display(Name = "Version")]
        public string Version { get; set; }
    }

    public class HardwareProfile
    {

        [DataMember(Name = "VMSize")]
        [Display(Name = "VMSize")]
        public string VMSize { get; set; }
    }

    public class IPAddress
    {
        [DataMember(Name = "AllocationMethod")]
        [Display(Name = "AllocationMethod")]
        public string AllocationMethod { get; set; }

        [DataMember(Name = "ConfigurationName")]
        [Display(Name = "ConfigurationName")]
        public string ConfigurationName { get; set; }

        [DataMember(Name = "LoadBalancerConfigurations")]
        [Display(Name = "LoadBalancerConfigurations")]
        public List<object> LoadBalancerConfigurations { get; set; }

        [DataMember(Name = "Type")]
        [Display(Name = "Type")]
        public string Type { get; set; }
    }

    public class NetworkAdapter
    {
        [DataMember(Name = "IPAddresses")]
        [Display(Name = "IPAddresses")]
        public List<IPAddress> IPAddresses { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "NetworkRef")]
        [Display(Name = "NetworkRef")]
        public string NetworkRef { get; set; }
    }

    public class NetworkProfile
    {
        [DataMember(Name = "NetworkAdapters")]
        [Display(Name = "NetworkAdapters")]
        public List<NetworkAdapter> NetworkAdapters { get; set; }
    }

    public class LinuxOperatingSystemProfile
    {
        [DataMember(Name = "DNSDomainName")]
        [Display(Name = "DNSDomainName")]
        public string DNSDomainName { get; set; }

        [DataMember(Name = "SSHPublicKey")]
        [Display(Name = "SSHPublicKey")]
        public string SSHPublicKey { get; set; }
    }

    public class OperatingSystemProfile
    {
        [DataMember(Name = "AdminCredential")]
        [Display(Name = "AdminCredential")]
        public string AdminCredential { get; set; }

        [DataMember(Name = "ComputerNamePattern")]
        [Display(Name = "ComputerNamePattern")]
        public string ComputerNamePattern { get; set; }

        [DataMember(Name = "LinuxOperatingSystemProfile")]
        [Display(Name = "LinuxOperatingSystemProfile")]
        public LinuxOperatingSystemProfile LinuxOperatingSystemProfile { get; set; }

        [DataMember(Name = "TimeZone")]
        [Display(Name = "TimeZone")]
        public string TimeZone { get; set; }

        [DataMember(Name = "WindowsOperatingSystemProfile")]
        [Display(Name = "WindowsOperatingSystemProfile")]
        public object WindowsOperatingSystemProfile { get; set; }
    }

    public class ScaleOutSettings
    {
        [DataMember(Name = "InitialInstanceCount")]
        [Display(Name = "InitialInstanceCount")]
        public string InitialInstanceCount { get; set; }

        [DataMember(Name = "MaximumInstanceCount")]
        [Display(Name = "MaximumInstanceCount")]
        public string MaximumInstanceCount { get; set; }

        [DataMember(Name = "MinimumInstanceCount")]
        [Display(Name = "MinimumInstanceCount")]
        public string MinimumInstanceCount { get; set; }

        [DataMember(Name = "UpgradeDomainCount")]
        [Display(Name = "UpgradeDomainCount")]
        public string UpgradeDomainCount { get; set; }
    }

    public class StorageProfile
    {
        [DataMember(Name = "DataVirtualHardDisks")]
        [Display(Name = "DataVirtualHardDisks")]
        public List<object> DataVirtualHardDisks { get; set; }

        [DataMember(Name = "OSVirtualHardDiskImage")]
        [Display(Name = "OSVirtualHardDiskImage")]
        public string OSVirtualHardDiskImage { get; set; }
    }

    public class IntrinsicSettings
    {
        [DataMember(Name = "HardwareProfile")]
        [Display(Name = "HardwareProfile")]
        public HardwareProfile HardwareProfile { get; set; }

        [DataMember(Name = "NetworkProfile")]
        [Display(Name = "NetworkProfile")]
        public NetworkProfile NetworkProfile { get; set; }

        [DataMember(Name = "OperatingSystemProfile")]
        [Display(Name = "OperatingSystemProfile")]
        public OperatingSystemProfile OperatingSystemProfile { get; set; }

        [DataMember(Name = "ScaleOutSettings")]
        [Display(Name = "ScaleOutSettings")]
        public ScaleOutSettings ScaleOutSettings { get; set; }

        [DataMember(Name = "StorageProfile")]
        [Display(Name = "StorageProfile")]
        public StorageProfile StorageProfile { get; set; }
    }

    public class ResourceExtensionReference
    {
        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Publisher")]
        [Display(Name = "Publisher")]
        public string Publisher { get; set; }

        [DataMember(Name = "ReferenceName")]
        [Display(Name = "ReferenceName")]
        public string ReferenceName { get; set; }

        [DataMember(Name = "ResourceExtensionParameterValues")]
        [Display(Name = "ResourceExtensionParameterValues")]
        public string ResourceExtensionParameterValues { get; set; }

        [DataMember(Name = "Version")]
        [Display(Name = "Version")]
        public string Version { get; set; }
    }

    public class ResourceParameter
    {
        [DataMember(Name = "Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Type")]
        [Display(Name = "Type")]
        public string Type { get; set; }
    }


    public class VMRoleInstanceList : List<VMRoleInstance>
    {
        public VMRoleInstanceList()
            : base()
        {
        }

        public VMRoleInstanceList(IEnumerable<VMRoleInstance> records)
            : base(records)
        {
        }
    }

    [DataContract]
    public class VMRoleViewDefinition
    {
        [DataMember(Name = "ViewDefinition")]
        [Display(Name = "ViewDefinition")]
        public ViewDefinition ViewDefinition { get; set; }

        [DataMember(Name = "Localization")]
        [Display(Name = "Localization")]
        public Localization Localization { get; set; }
    }

    public class Section
    {
        [DataMember(Name = "Title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [DataMember(Name = "Categories")]
        [Display(Name = "Categories")]
        public string Categories { get; set; }
    }

    public class ViewDefinition
    {
        [DataMember(Name = "Version")]
        [Display(Name = "Version")]
        public string Version { get; set; }

        [DataMember(Name = "Label")]
        [Display(Name = "Label")]
        public string Label { get; set; }

        [DataMember(Name = "PublisherLabel")]
        [Display(Name = "PublisherLabel")]
        public string PublisherLabel { get; set; }

        [DataMember(Name = "Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "DefaultLanguageCode")]
        [Display(Name = "DefaultLanguageCode")]
        public string DefaultLanguageCode { get; set; }

        [DataMember(Name = "Sections")]
        [Display(Name = "Sections")]
        public List<Section> Sections { get; set; }
    }

    public class Localization
    {
        [DataMember(Name = "LanguageCode")]
        [Display(Name = "LanguageCode")]
        public string LanguageCode { get; set; }

        [DataMember(Name = "Resources")]
        [Display(Name = "Resources")]
        public string Resources { get; set; }
    }

}
