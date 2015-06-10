using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade
{
    [DataContract]
    public class Subscription
    {
        [DataMember(Name = "SubscriptionID")]
        [Display(Name = "ID")]
        public string SubscriptionID { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Status")]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [DataMember(Name = "OfferCategory")]
        [Display(Name = "Offer Category")]
        public string OfferCategory { get; set; }

        [DataMember(Name = "OfferFriendlyName")]
        [Display(Name = "Offer Name")]
        public string OfferFriendlyName { get; set; }

        [DataMember(Name = "PlanId")]
        [Display(Name = "Plan ID")]
        public string PlanId { get; set; }

        [DataMember(Name = "Services")]
        [Display(Name = "Services")]
        public Services[] Services { get; set; }

        [DataMember(Name = "LastErrorMessage")]
        [Display(Name = "Last Error Message")]
        public string LastErrorMessage { get; set; }

        [DataMember(Name = "CoAdminNames")]
        [Display(Name = "Co-Admins")]
        public string[] CoAdminNames { get; set; }
    }

    public class AddOns
    {
        //Todo
    }
    public class AddOnReferences
    {
        //Todo
    }

    public class Services
    {
        [DataMember(Name = "Type")]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [DataMember(Name = "State")]
        [Display(Name = "State")]
        public string State { get; set; }

        [DataMember(Name = "QuotaSyncState")]
        [Display(Name = "Quota Sync State")]
        public string QuotaSyncState { get; set; }

        [DataMember(Name = "ActivationSyncState")]
        [Display(Name = "Activation Sync State")]
        public string ActivationSyncState { get; set; }
    }
    public class CoAdmins
    {
        [DataMember(Name = "Name")]
        [Display(Name = "Co-Admin User Names")]
        public string name { get; set; }
    }
    public class SubscriptionList : List<Subscription>
    {
        /// <summary>
        /// Initializes a new instance of the Subscription class.
        /// </summary>
        public SubscriptionList()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        /// <param name="records">The records.</param>
        public SubscriptionList(IEnumerable<Subscription> records)
            : base(records)
        {
        }
    }
}
