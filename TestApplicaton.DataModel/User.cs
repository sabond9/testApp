using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicaton.DataModel
{
    public class User
    {
        public User()
        {
            UserPasswords = new HashSet<UserPassword>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int InvalidLoginAttempsCount { get; set; }

        public bool IsLocked { get; set; }

        public bool IsRemoved { get; set; }

        public DateTime PasswordLastChangedDate { get; set; }

        public DateTime LastLoginDateTime { get; set; }

        public bool IsNew { get; set; }

        public string ResetPasswordHash { get; set; }

        public DateTime ResetPasswordSendDateTime { get; set; }

        public ICollection<UserPassword> UserPasswords { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } 
    }
}
