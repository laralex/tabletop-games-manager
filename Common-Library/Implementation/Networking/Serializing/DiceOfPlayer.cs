using System;
using System.Collections.Generic;
using CommonLibrary.Implementation.Games.Dice;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    /// <summary>
    /// Players select some Dice and server sends message to other players about it
    /// </summary>
    [Serializable]
    class DiceOfPlayer
    {
        public DiceGamePlayer Player { get; set; }
        public List<Die> Dice { get; set; }

        public DiceOfPlayer(DiceGamePlayer player, List<Die> dice)
        {
            Player = player;
            Dice = dice;
        }
    }
}
