using CommonLibrary.Implementation.ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Serializing
{
    /// <summary>
    /// Users request a servers list from Head server
    /// </summary>
    [Serializable]
    public class AllServersList
    {
        public List<GameServerEntry> ServersList { get; set; }

        public AllServersList(List<GameServerEntry> serversList)
        {
            ServersList = serversList;
        }
    }
}
