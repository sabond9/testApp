using System.Data.Entity.ModelConfiguration;
using TestApplicaton.DataModel.Models;

namespace TestApplicaton.DataModel.ModelConfigurations
{
    public class PermissionTypeConfiguration : EntityTypeConfiguration<PermissionType>
    {
        public PermissionTypeConfiguration()
        {
            Property(r => r.Name).IsRequired().HasMaxLength(100);
        }
    }
}
