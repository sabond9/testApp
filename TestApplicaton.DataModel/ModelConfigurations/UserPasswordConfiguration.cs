using System.Data.Entity.ModelConfiguration;
using TestApplicaton.DataModel.Models;

namespace TestApplicaton.DataModel.ModelConfigurations
{
    public class UserPasswordConfiguration : EntityTypeConfiguration<UserPassword>
    {
        public UserPasswordConfiguration()
        {
            Property(r => r.SetPasswordDateTime).IsOptional();
            Property(r => r.PasswordHash).IsOptional().HasMaxLength(100);
        }
    }
}
