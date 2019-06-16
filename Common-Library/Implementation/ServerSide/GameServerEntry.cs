using System;
using System.Net;

namespace CommonLibrary.Implementation.ServerSide
{
    /// <summary>
    /// Game Server registration data for Head Server
    /// </summary>
    [Serializable]
    public class GameServerEntry
    {
        public string Name { get; set; }
        public string CreatorName { get; set; }
        public bool IsActive { get; set; }
        public IPEndPoint Socket { get; set; }
        public int MaxPlayers { get; set; }
    }
}
