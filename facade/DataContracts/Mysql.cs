using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade.DataContracts
{
    [DataContract]
    public class MySqlDatabase
    {
        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "MySqlServerName")]
        [Display(Name = "MySqlServerName")]
        public string MySqlServerName { get; set; }

        [DataMember(Name = "MySqlServerId")]
        [Display(Name = "MySqlServerId")]
        public string MySqlServerId { get; set; }

        [DataMember(Name = "SubscriptionId")]
        [Display(Name = "SubscriptionId")]
        public string SubscriptionId { get; set; }

        [DataMember(Name = "ConnectionString")]
        [Display(Name = "ConnectionString")]
        public string ConnectionString { get; set; }

        [DataMember(Name = "Edition")]
        [Display(Name = "Edition")]
        public string Edition { get; set; }

        [DataMember(Name = "MaxSizeMB")]
        [Display(Name = "MaxSizeMB")]
        public int? MaxSizeMB { get; set; }

        [DataMember(Name = "Collation")]
        [Display(Name = "Collation")]
        public string Collation { get; set; }

        [DataMember(Name = "CreationDate")]
        [Display(Name = "CreationDate")]
        public string CreationDate { get; set; }

        [DataMember(Name = "ModifiedDate")]
        [Display(Name = "ModifiedDate")]
        public string ModifiedDate { get; set; }

        [DataMember(Name = "Status")]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [DataMember(Name = "AdminLogon")]
        [Display(Name = "AdminLogon")]
        public string AdminLogon { get; set; }

        [DataMember(Name = "Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataMember(Name = "Quota")]
        [Display(Name = "Quota")]
        public string Quota { get; set; }

        [DataMember(Name = "AccountAdminId")]
        [Display(Name = "AccountAdminId")]
        public object AccountAdminId { get; set; }
    }

    public class MySqlDatabaseList : List<MySqlDatabase>
    {
        public MySqlDatabaseList()
            : base()
        {
        }

        public MySqlDatabaseList(IEnumerable<MySqlDatabase> records)
            : base(records)
        {
        }
    }
}
