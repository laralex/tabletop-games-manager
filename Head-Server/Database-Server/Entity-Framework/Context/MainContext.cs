using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using HeadServer.DB;

namespace HeadServer.DB.Context
{
    class MainContext : DbContext
    {
        public DbSet<GameServer> GameServers { get; set; }
        //public DbSet<DiceGameServer> DiceGameServers { get; set; }
        public DbSet<User> Users { get; set; }
        public MainContext() : base() // nameOrConnectionString: "LarGM-Postgres"
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.ForNpgsqlUseIdentityColumns();
            base.OnModelCreating(modelBuilder);
        }
    }
}
