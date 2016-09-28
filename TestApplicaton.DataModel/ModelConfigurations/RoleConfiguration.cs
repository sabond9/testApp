using System.Data.Entity.ModelConfiguration;
using TestApplicaton.DataModel.Models;

namespace TestApplicaton.DataModel.ModelConfigurations
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            Property(r => r.Name).IsRequired().HasMaxLength(100);
            Property(r => r.Description).IsOptional().HasMaxLength(200);
        }
    }
}
