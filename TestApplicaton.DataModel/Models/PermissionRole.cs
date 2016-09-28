using System.ComponentModel.DataAnnotations.Schema;

namespace TestApplicaton.DataModel.Models
{
    public class PermissionRole
    {
        public int Id { get; set; }

        public int PermissionId { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("FK_PermissionRole_Role")]
        public Role Role { get; set; }

        [ForeignKey("FK_PermissionRole_Permission")]
        public Permission Permission { get; set; }
    }
}
