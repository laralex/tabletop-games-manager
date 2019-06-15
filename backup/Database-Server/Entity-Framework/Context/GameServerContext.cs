using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Data.Entity;
//using System.ComponentModel.DataAnnotations;
//using Microsoft.EntityFrameworkCore;

namespace HeadServer.DB.Context
{
   /*internal class GameServerContext : DbContext
    {
        public DbSet<GameServer> GameServers { get; set; }
        public DbSet<DiceGameServer> DiceGameServers { get; set; }
        public GameServerContext() : base() // nameOrConnectionString: "LarGM-Postgres"
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.ForNpgsqlUseIdentityColumns();
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseNpgsql("Host=localhost;Database=my_db;Username=my_user;Password=my_pw");
        } 
    }
    */
}
