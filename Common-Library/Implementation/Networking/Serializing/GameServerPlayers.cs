using CommonLibrary.Model.Games;
using System;
using System.Collections.Generic;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    /// <summary>
    /// Before start, server sends information about all connected players
    /// </summary>
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
