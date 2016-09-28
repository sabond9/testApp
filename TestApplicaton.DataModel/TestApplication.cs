using System;
using System.Data.Entity;
using System.Data.Entity.Spatial;
using System.Linq;

namespace TestApplicaton.DataModel
{
    public class TestApplication : DbContext
    {
        // Your context has been configured to use a 'TestApplication' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TestApplicaton.DataModel.TestApplication' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TestApplication' 
        // connection string in the application configuration file.
        public TestApplication()
            : base("name=TestApplication")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<PermissionRole> PermissionRoles { get; set; }

        public DbSet<PermissionType> PermissionTypes { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }
        
        public DbSet<UserPassword> UserPasswords { get; set; }

        public DbSet<UserRole> UserRoles { get; set; } 
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}