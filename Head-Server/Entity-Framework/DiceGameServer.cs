﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HeadServer.EntityFramework
{
    public class DiceGameServer
    {
        [Key] public int    ServerId { get; set; }

        public int?         TurnTimeSec { get; set; }
        public int          ScoreGoal { get; set; }
        public int          DiceNumber { get; set; }
        public bool         IsJokerAllowed { get; set; }
    }
}