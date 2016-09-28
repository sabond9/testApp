using System.Collections.Generic;

namespace TestApplicaton.DataModel.Models
{
    public class Permission
    {
        public Permission()
        {
            PermissionRoles = new HashSet<PermissionRole>();
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public int PermissionTypeId { get; set; }

        public PermissionType PermissionType { get; set; }

        public ICollection<PermissionRole> PermissionRoles { get; set; }
    }
}
