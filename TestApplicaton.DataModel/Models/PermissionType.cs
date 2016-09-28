using System.Collections.Generic;

namespace TestApplicaton.DataModel.Models
{
    public class PermissionType
    {
        public PermissionType()
        {
            Permissions = new HashSet<Permission>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Permission> Permissions { get; set; } 
    }
}
