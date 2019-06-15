using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Implementation.ServerSide
{
    public class DiceGameServerEntry : GameServerEntry
    {
        public int? TurnTimeSec { get; set; }
        public int ScoreGoal { get; set; }
        public int DiceNumber { get; set; }
        public bool IsJokerAllowed { get; set; }
    }
}
