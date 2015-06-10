using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade
{
    [DataContract]
    public class SqlDatabase
    {
        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "SqlServerName")]
        [Display(Name = "SqlServerName")]
        public string SqlServerName { get; set; }

        [DataMember(Name = "SqlServerId")]
        [Display(Name = "SqlServerId")]
        public string SqlServerId { get; set; }

        [DataMember(Name = "SubscriptionId")]
        [Display(Name = "SubscriptionId")]
        public string SubscriptionId { get; set; }

        [DataMember(Name = "ConnectionString")]
        [Display(Name = "ConnectionString")]
        public string ConnectionString { get; set; }

        [DataMember(Name = "Edition")]
        [Display(Name = "Edition")]
        public string Edition { get; set; }

        [DataMember(Name = "BaseSizeMB")]
        [Display(Name = "BaseSizeMB")]
        public int? BaseSizeMB { get; set; }

        [DataMember(Name = "MaxSizeMB")]
        [Display(Name = "MaxSizeMB")]
        public int? MaxSizeMB { get; set; }

        [DataMember(Name = "Collation")]
        [Display(Name = "Collation")]
        public string Collation { get; set; }

        [DataMember(Name = "IsContained")]
        [Display(Name = "IsContained")]
        public bool? IsContained { get; set; }

        [DataMember(Name = "CreationDate")]
        [Display(Name = "CreationDate")]
        public string CreationDate { get; set; }

        [DataMember(Name = "Status")]
        [Display(Name = "Status")]
        public int? Status { get; set; }

        [DataMember(Name = "SelfLink")]
        [Display(Name = "SelfLink")]
        public object SelfLink { get; set; }

        [DataMember(Name = "Quota")]
        [Display(Name = "Quota")]
        public string Quota { get; set; }

        [DataMember(Name = "AdminLogon")]
        [Display(Name = "AdminLogon")]
        public string AdminLogon { get; set; }

        [DataMember(Name = "Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataMember(Name = "AccountAdminId")]
        [Display(Name = "AccountAdminId")]
        public object AccountAdminId { get; set; }
    }

    public class SqlDatabaseList : List<SqlDatabase>
    {
        public SqlDatabaseList()
            : base()
        {
        }

        public SqlDatabaseList(IEnumerable<SqlDatabase> records)
            : base(records)
        {
        }
    }
}
