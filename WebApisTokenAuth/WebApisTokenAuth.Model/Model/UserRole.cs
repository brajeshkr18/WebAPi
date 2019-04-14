using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApisTokenAuth.Model.Model
{
    public class UserRole
    {
        public UserRole()
        {
            this.ApplicationUsers = new HashSet<ApplicationUser>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
