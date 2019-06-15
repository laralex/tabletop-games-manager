using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonLibrary.Implementation.ServerSide;

using GameClient.GUI.ServerManager;

namespace GameClient.Application
{
    internal class LobbyBackend
    {
        public List<GameServerEntry> KnownActiveGameServers { get; private set; }
        public ServersList Frontend { get; private set; }
        public LobbyBackend(ServersList frontend)
        {
            KnownActiveGameServers = new List<GameServerEntry>();
            Frontend = frontend;

            Frontend.JoinClick += OnJoin;
            Frontend.RefreshClick += OnRefresh;
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            // TODO: Network
            
            KnownActiveGameServers = new List<GameServerEntry>();
            Frontend.SetServersList(KnownActiveGameServers);
            throw new NotImplementedException();
        }

        private void OnJoin(object sender, JoinEventArgs e)
        {
            // TODO: Network
            // Load server
            var server = KnownActiveGameServers[e.ServersListIndex];
            // Switch tab
            throw new NotImplementedException();
        }

         
    }
}
