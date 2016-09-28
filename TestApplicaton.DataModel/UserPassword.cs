using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicaton.DataModel
{
    public class UserPassword
    {
        public int Id { get; set; }

        public DateTime SetPasswordDateTime { get; set; }

        public string PasswordHash { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
