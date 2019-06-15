using CommonLibrary.Model.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    [Serializable]
    public class GameServerPlayer
    {
        public IPlayer Player;

        public GameServerPlayer(IPlayer player)
        {
            Player = player;
        }
    }
}
