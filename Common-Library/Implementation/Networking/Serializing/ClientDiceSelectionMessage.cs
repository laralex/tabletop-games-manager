using CommonLibrary.Implementation.Games.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    [Serializable]
    class ClientDiceSelectionMessage
    {
        public DiceGamePlayer Player { get; set; }
        public List<Die> Dice { get; set; }

        public ClientDiceSelectionMessage(DiceGamePlayer player, List<Die> dice)
        {
            Player = player;
            Dice = dice;
        }
    }
}
