using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HeadServer.DB
{
    internal class DiceGameServer : GameServer
    {
        public int?         TurnTimeSec { get; set; }
        public int          ScoreGoal { get; set; }
        public int          DiceNumber { get; set; }
        public bool         IsJokerAllowed { get; set; }
    }
}
