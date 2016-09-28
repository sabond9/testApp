using System;
using System.Data.Entity;
using System.Data.Entity.Spatial;
using System.Linq;
using TestApplicaton.DataModel.Models;

namespace TestApplicaton.DataModel
{
    public class TestApplication : DbContext
    {
        public TestApplication()
            : base("name=TestApplication")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<PermissionRole> PermissionRoles { get; set; }

        public DbSet<PermissionType> PermissionTypes { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }
        
        public DbSet<UserPassword> UserPasswords { get; set; }

        public DbSet<UserRole> UserRoles { get; set; } 
    }
}