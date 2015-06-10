using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Microsoft.Wap.Facade.DataContracts
{
    [DataContract]
    public class GalleryItem
    {    
	    [DataMember(Name = "odata.type")]
	    [Display(Name = "odata.type")]
	    public string odatatype { get; set; }
    
	    [DataMember(Name = "Name")]
	    [Display(Name = "Name")]
	    public string Name { get; set; }
    
	    [DataMember(Name = "Publisher")]
	    [Display(Name = "Publisher")]
	    public string Publisher { get; set; }
    
	    [DataMember(Name = "Version")]
	    [Display(Name = "Version")]
	    public string Version { get; set; }
    
	    [DataMember(Name = "ContentUrl")]
	    [Display(Name = "ContentUrl")]
	    public string ContentUrl { get; set; }
    
	    [DataMember(Name = "Description")]
	    [Display(Name = "Description")]
	    public string Description { get; set; }
    
	    [DataMember(Name = "IconUrl")]
	    [Display(Name = "IconUrl")]
	    public object IconUrl { get; set; }
    
	    [DataMember(Name = "Label")]
	    [Display(Name = "Label")]
	    public string Label { get; set; }
    
	    [DataMember(Name = "PublishDate")]
	    [Display(Name = "PublishDate")]
	    public string PublishDate { get; set; }
    
	    [DataMember(Name = "PublisherLabel")]
	    [Display(Name = "PublisherLabel")]
	    public string PublisherLabel { get; set; }
    
	    [DataMember(Name = "ResourceDefinition@odata.mediaContentType")]
	    [Display(Name = "ResourceDefinition@odata.mediaContentType")]
	    public string ResourceDefinitiono_data_mediaContentType { get; set; }
    
	    [DataMember(Name = "ResourceDefinitionUrl")]
	    [Display(Name = "ResourceDefinitionUrl")]
	    public string ResourceDefinitionUrl { get; set; }
    
	    [DataMember(Name = "ViewDefinitionUrl")]
	    [Display(Name = "ViewDefinitionUrl")]
	    public string ViewDefinitionUrl { get; set; }
    }

    public class GalleryItemList : List<GalleryItem>
    {
        public GalleryItemList()
            : base()
        {
        }

        public GalleryItemList(IEnumerable<GalleryItem> records)
            : base(records)
        {
        }
    }
}
