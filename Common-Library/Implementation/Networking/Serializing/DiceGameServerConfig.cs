using CommonLibrary.Implementation.Games.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    [Serializable]
    public class DiceGameServerConfig
    {
        public string GameType  { get => "DICE"; }
        public DiceGameOptions Config { get; }
        public DiceGameServerConfig(DiceGameOptions config)
        {
            Config = config;
        }

          
    }
}
