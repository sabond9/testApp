using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("FK_Permission_PermissionType")]
        public PermissionType PermissionType { get; set; }

        public ICollection<PermissionRole> PermissionRoles { get; set; }
    }
}
