using CommonLibrary.Model.Games;
using System;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    /// <summary>
    /// Players join and leave server, and server notifies others about it
    /// </summary>
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
