using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace HeadServer.DB
{
    public class GameServer
    {
        [Key] public int    Id { get; set; }

        public string       Name { get; set; }
        public User         Creator { get; set; }
        public DateTime     RegisterTime { get; set; }
        public bool         IsActive { get; set; }
        public IPEndPoint   Socket { get; set; }

        //public DiceGameServer DiceGameServer { get; set; }
    }
}
