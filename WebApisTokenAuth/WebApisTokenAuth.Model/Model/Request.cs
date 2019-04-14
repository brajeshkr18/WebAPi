using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApisTokenAuth.Model
{
    public class Request
    {

        public System.Guid Id { get; set; }
        public string Headers { get; set; }
        public string Url { get; set; }
        public string PathVariables { get; set; }
        public int Owner { get; set; }
        public string PreRequestScript { get; set; }
        public string Method { get; set; }
        public System.Guid CollectionId { get; set; }
        public string Data { get; set; }
        public string DataMode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DescriptionFormat { get; set; }
        public TimeSpan Time { get; set; }
        public string Version { get; set; }
        public string Responses { get; set; }
        public string Tests { get; set; }
        public string CurrentHelper { get; set; }
        public string HelperAttributes { get; set; }
        public bool IsFromCollection { get; set; }
        public System.Guid FolderId { get; set; }
        public string RawModeData { get; set; }
    }
}