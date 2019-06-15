using CommonLibrary.Implementation.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    [Serializable]
    public class GameServerStatus
    {
        public GameOptions GameOptions {get; set;}
        public int ConnectedPlayersNumber { get; set; }
        public string ServerStatusTitle { get; set; }

        public GameServerStatus(GameOptions gameOptions, int connectedPlayersNumber, string serverStatusTitle)
        {
            GameOptions = gameOptions;
            ConnectedPlayersNumber = connectedPlayersNumber;
            ServerStatusTitle = serverStatusTitle;
        }
    }
}
