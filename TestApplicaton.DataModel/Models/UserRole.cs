using System.ComponentModel.DataAnnotations.Schema;

namespace TestApplicaton.DataModel.Models
{
    public class UserRole
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("FK_UserRole_User")]
        public User User { get; set; }

        [ForeignKey("FK_UserRole_Role")]
        public Role Role { get; set; }
    }
}
