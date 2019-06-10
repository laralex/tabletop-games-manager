using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HeadServer.DB.Context
{
    internal class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext() : base(nameOrConnectionString: "LarGM-Postgres")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            //modelBuilder.ForNpgsqlUseIdentityColumns();
            base.OnModelCreating(modelBuilder);
        }
    }
}
