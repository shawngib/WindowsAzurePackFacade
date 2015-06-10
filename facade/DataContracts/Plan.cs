using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade
{
    [DataContract]
    public class Plan
    {
        [DataMember(Name = "Id")]
        [Display(Name = "ID")]
        public string Id { get; set; }

        [DataMember(Name = "DisplayName")]
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }

        [DataMember(Name = "State")]
        [Display(Name = "State")]
        public int? State { get; set; }

        [DataMember(Name = "ConfigState")]
        [Display(Name = "Config State")]
        public int? ConfigState { get; set; }

        [DataMember(Name = "DisplayName")]
        [Display(Name = "Display Name")]
        public int? QuotaSyncState { get; set; }

        [DataMember(Name = "LastErrorMessage")]
        [Display(Name = "Last Error Message")]
        public object LastErrorMessage { get; set; }

        [DataMember(Name = "Advertisements")]
        [Display(Name = "Advertisements")]
        public List<Advertisement> Advertisements { get; set; }

        [DataMember(Name = "ServiceQuotas")]
        [Display(Name = "Service Quotas")]
        public List<ServiceQuota> ServiceQuotas { get; set; }

        [DataMember(Name = "SubscriptionCount")]
        [Display(Name = "Subscription Count")]
        public int? SubscriptionCount { get; set; }

        [DataMember(Name = "MaxSubscriptionsPerAccount")]
        [Display(Name = "Max Subscriptions")]
        public int? MaxSubscriptionsPerAccount { get; set; }

        [DataMember(Name = "AddOnReferences")]
        [Display(Name = "Add On References")]
        public List<object> AddOnReferences { get; set; }

        [DataMember(Name = "AddOns")]
        [Display(Name = "AddOns")]
        public List<object> AddOns { get; set; }

        [DataMember(Name = "InvitationCode")]
        [Display(Name = "Invitation Code")]
        public string InvitationCode { get; set; }

        [DataMember(Name = "Price")]
        [Display(Name = "Price")]
        public int? Price { get; set; }
    }

    public class Advertisement
    {
        [DataMember(Name = "LanguageCode")]
        [Display(Name = "LanguageCode")]
        public string LanguageCode { get; set; }

        [DataMember(Name = "DisplayName")]
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }

        [DataMember(Name = "Description")]
        [Display(Name = "Description")]
        public object Description { get; set; }
    }

    public class ServiceQuota
    {
        [DataMember(Name = "ServiceName")]
        [Display(Name = "Service Name")]
        public string ServiceName { get; set; }

        [DataMember(Name = "ServiceInstanceId")]
        [Display(Name = "Service Instance Id")]
        public string ServiceInstanceId { get; set; }

        [DataMember(Name = "ServiceDisplayName")]
        [Display(Name = "Service Name")]
        public string ServiceDisplayName { get; set; }

        [DataMember(Name = "ServiceInstanceDisplayName")]
        [Display(Name = "Service Instance Name")]
        public string ServiceInstanceDisplayName { get; set; }

        [DataMember(Name = "ConfigState")]
        [Display(Name = "Config State")]
        public int ConfigState { get; set; }

        [DataMember(Name = "QuotaSyncState")]
        [Display(Name = "Quota Sync State")]
        public int QuotaSyncState { get; set; }

        [DataMember(Name = "Settings")]
        [Display(Name = "Settings")]
        public List<object> Settings { get; set; }
    }

    public class PlanList : List<Plan>
    {
        public PlanList()
            : base()
        {
        }

        public PlanList(IEnumerable<Plan> records)
            : base(records)
        {
        }
    }
}
