using System.Data.Entity.ModelConfiguration;
using TestApplicaton.DataModel.Models;

namespace TestApplicaton.DataModel.ModelConfigurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(r => r.UserName).IsRequired().HasMaxLength(100);
            Property(r => r.PasswordHash).IsOptional().HasMaxLength(100);
            Property(r => r.Email).IsRequired().HasMaxLength(100);
            Property(r => r.FirstName).IsRequired().HasMaxLength(100);
            Property(r => r.LastName).IsRequired().HasMaxLength(100);
            Property(r => r.InvalidLoginAttempsCount).IsOptional();
            Property(r => r.IsLocked).IsOptional();
            Property(r => r.IsRemoved).IsOptional();
            Property(r => r.PasswordLastChangedDate).IsOptional();
            Property(r => r.LastLoginDateTime).IsOptional();
            Property(r => r.IsNew).IsOptional();
            Property(r => r.ResetPasswordHash).IsOptional().HasMaxLength(100);
            Property(r => r.ResetPasswordSendDateTime).IsOptional();
        }
    }
}
