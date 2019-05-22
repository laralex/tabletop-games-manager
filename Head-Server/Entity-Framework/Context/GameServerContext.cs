using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HeadServer.EntityFramework
{
    class GameServerContext : DbContext
    {
        public DbSet<GameServer> GameServers { get; set; }

        public GameServerContext() : base(nameOrConnectionString: "LarGM-Postgres")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
