using System.Collections.Generic;

namespace TestApplicaton.DataModel.Models
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
