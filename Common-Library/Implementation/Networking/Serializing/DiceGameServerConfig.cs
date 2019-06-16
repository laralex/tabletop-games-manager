using CommonLibrary.Implementation.Games.Dice;
using System;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    /// <summary>
    /// Players request game server's configuration, and server sends it 
    /// </summary>
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
