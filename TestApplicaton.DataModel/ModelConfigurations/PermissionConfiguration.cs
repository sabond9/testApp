using System.Data.Entity.ModelConfiguration;
using TestApplicaton.DataModel.Models;

namespace TestApplicaton.DataModel.ModelConfigurations
{
    public class PermissionConfiguration : EntityTypeConfiguration<Permission>
    {
        public PermissionConfiguration()
        {
            Property(r => r.Id).IsRequired();
            Property(r => r.PermissionTypeId).IsRequired();
            Property(r => r.Description).IsRequired().HasMaxLength(100);
        }
    }
}
