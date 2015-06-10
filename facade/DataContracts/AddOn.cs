using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade.DataContracts
{
    [DataContract]
    public class AddOn
    {
        [DataMember(Name = "Id")]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [DataMember(Name = "DisplayName")]
        [Display(Name = "DisplayName")]
        public string DisplayName { get; set; }

        [DataMember(Name = "State")]
        [Display(Name = "State")]
        public int State { get; set; }

        [DataMember(Name = "ConfigState")]
        [Display(Name = "ConfigState")]
        public int ConfigState { get; set; }

        [DataMember(Name = "QuotaSyncState")]
        [Display(Name = "QuotaSyncState")]
        public int QuotaSyncState { get; set; }

        [DataMember(Name = "LastErrorMessage")]
        [Display(Name = "LastErrorMessage")]
        public object LastErrorMessage { get; set; }

        [DataMember(Name = "Advertisements")]
        [Display(Name = "Advertisements")]
        public List<Advertisement> Advertisements { get; set; }

        [DataMember(Name = "ServiceQuotas")]
        [Display(Name = "ServiceQuotas")]
        public List<ServiceQuota> ServiceQuotas { get; set; }

        [DataMember(Name = "SubscriptionCount")]
        [Display(Name = "SubscriptionCount")]
        public int SubscriptionCount { get; set; }

        [DataMember(Name = "AssociatedPlans")]
        [Display(Name = "AssociatedPlans")]
        public List<object> AssociatedPlans { get; set; }

        [DataMember(Name = "MaxOccurrencesPerPlan")]
        [Display(Name = "MaxOccurrencesPerPlan")]
        public int MaxOccurrencesPerPlan { get; set; }

        [DataMember(Name = "Price")]
        [Display(Name = "Price")]
        public object Price { get; set; }
    }
    
    public class Advertisement
    {
        public string LanguageCode { get; set; }
        public string DisplayName { get; set; }
        public object Description { get; set; }
    }

    public class ServiceQuota
    {
        public string ServiceName { get; set; }
        public string ServiceInstanceId { get; set; }
        public string ServiceDisplayName { get; set; }
        public string ServiceInstanceDisplayName { get; set; }
        public int ConfigState { get; set; }
        public int QuotaSyncState { get; set; }
        public string Settings { get; set; }
    }

    public class AddOnList : List<AddOn>
    {
        public AddOnList()
            : base()
        {
        }

        public AddOnList(IEnumerable<AddOn> records)
            : base(records)
        {
        }
    }
}
