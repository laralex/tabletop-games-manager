using CommonLibrary.Implementation.Games;
using System;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    /// <summary>
    /// Game servers send status updates to Head server
    /// </summary>
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
