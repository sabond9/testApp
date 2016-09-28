using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicaton.DataModel
{
    public class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
            PermissionRoles = new HashSet<PermissionRole>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } 

        public ICollection<PermissionRole> PermissionRoles { get; set; } 
    }
}
