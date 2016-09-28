using System;

namespace TestApplicaton.DataModel.Models
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
