using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HeadServer.EntityFramework
{
    class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext() : base(nameOrConnectionString: "LarGM-Postgres")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
