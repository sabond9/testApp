using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicaton.DataModel
{
    public class Permission
    {
        public Permission()
        {
            PermissionRoles = new HashSet<PermissionRole>();
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public int PermissionTypeId { get; set; }

        public PermissionType PermissionType { get; set; }

        public ICollection<PermissionRole> PermissionRoles { get; set; }
    }
}
