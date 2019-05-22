using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

using CommonLibrary;
using CommonLibrary.Implementation.Networking;
using CommonLibrary.Model;

namespace HeadServer
{
    public enum ServerStatus { Running, Stoped, Uninitialized }

    public class HeadServer
    {
        public string Id { get; internal set; }
        public ServerStatus Status { get; internal set; }
        public IPEndPoint Socket { get; internal set; }

        private IPlayer[] RecentPlayers;
        private GameServer[] RegisteredServers;
    }
}
