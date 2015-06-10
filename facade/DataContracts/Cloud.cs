using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade
{
    [DataContract]
    public class Cloud
    {
        [DataMember(Name = "ID")]
        [Display(Name = "ID")]
        public string ID { get; set; }

        [DataMember(Name = "Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "LastModifiedDate")]
        [Display(Name = "Last Modified")]
        public DateTime LastModifiedDate { get; set; }

        [DataMember(Name = "Writable Library Path")]
        [Display(Name = "Writable Library Path")]
        public string WritableLibraryPath { get; set; }

        [DataMember(Name = "StampId")]
        [Display(Name = "StampId")]
        public string StampId { get; set; }
    }

    public class CloudList : List<Cloud>
    {
        public CloudList()
            : base()
        {
        }

        public CloudList(IEnumerable<Cloud> records)
            : base(records)
        {
        }
    }
}
