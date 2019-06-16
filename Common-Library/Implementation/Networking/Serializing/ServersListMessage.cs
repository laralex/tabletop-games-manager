using CommonLibrary.Implementation.ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    [Serializable]
    public class ServersListMessage
    {
        public List<GameServerEntry> ServersList { get; set; }

        public ServersListMessage(List<GameServerEntry> serversList)
        {
            ServersList = serversList;
        }
    }
}
