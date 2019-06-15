using CommonLibrary.Model.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    [Serializable]
    public class GameServerPlayers
    {
        public List<IPlayer> Players;

        public GameServerPlayers(List<IPlayer> players)
        {
            Players = players;
        }
    }
}
