using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApisTokenAuth.Model
{
    public class OrderCollection
    {

     
        public OrderCollection()
        {
            this.Folders = new HashSet<Folder>();
            this.Requests = new HashSet<Request>();
        }

        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.TimeSpan> TimeStamp { get; set; }
        public Nullable<int> Owner { get; set; }
        public Nullable<bool> Public { get; set; }
        //public System.DateTime CreatedOn { get; set; }
        //public Nullable<long> ModifiedBy { get; set; }
        //public Nullable<System.DateTime> ModifiedOn { get; set; }
        //public bool IsActive { get; set; }
        //public bool IsDeleted { get; set; }
        //public Nullable<long> CreatedBy { get; set; }

        public virtual ICollection<Folder> Folders { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}