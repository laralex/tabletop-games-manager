using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace HeadServer.EntityFramework
{
    public class GameServer
    {
        [Key] public int    Id { get; set; }

        public string       Name { get; set; }
        public User         Creator { get; set; }
        public DateTime     CreationTime { get; set; }
        public bool         IsActive { get; set; }
        public IPEndPoint   IpPort { get; set; }
    }
}
