using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade.DataContracts
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataMember(Name = "State")]
        [Display(Name = "State")]
        public int? State { get; set; }

        [DataMember(Name = "CreatedTime")]
        [Display(Name = "CreatedTime")]
        public DateTime CreatedTime { get; set; }

        [DataMember(Name = "SubscriptionCount")]
        [Display(Name = "Subscription Count")]
        public int? SubscriptionCount { get; set; }

        [DataMember(Name = "ActivationSyncState")]
        [Display(Name = "ActivationSyncState")]
        public int? ActivationSyncState { get; set; }

        [DataMember(Name = "LastErrorMessage")]
        [Display(Name = "Last Error Message")]
        public object LastErrorMessage { get; set; }
    }
}
