//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApisTokenAuth.Core.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public System.Guid Id { get; set; }
        public string Headers { get; set; }
        public string Url { get; set; }
        public string PathVariables { get; set; }
        public Nullable<int> Owner { get; set; }
        public string PreRequestScript { get; set; }
        public string Method { get; set; }
        public System.Guid CollectionId { get; set; }
        public System.Guid FolderId { get; set; }
        public string Data { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public string DataMode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DescriptionFormat { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
        public string Version { get; set; }
        public string Responses { get; set; }
        public string Tests { get; set; }
        public string CurrentHelper { get; set; }
        public string HelperAttributes { get; set; }
        public Nullable<bool> IsFromCollection { get; set; }
        public string RawModeData { get; set; }
    
        public virtual Collection Collection { get; set; }
        public virtual Folder Folder { get; set; }
    }
}
