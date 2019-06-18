using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Windows.Forms;

using CommonLibrary.Implementation.Networking.Serializing;
using CommonLibrary.Implementation.Networking.Tcp;
using CommonLibrary.Implementation.ServerSide;
using CommonLibrary.Model.ServerSide;

using GameClient.GUI.ServerManager;

namespace GameClient.Application
{
    /// <summary>
    /// Backend class for managing "Lobby" tab in application
    /// </summary>
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

            var to_head_client = EntryPoint.InitHeadTcpClient();
            ConnectionProtocolUtility.SendGreetings(
                to_head_client, 
                EntryPoint.HeadTcpEndPoint, 
                EntryPoint.ProjectIdentifier
            );

            try
            {
                to_head_client.Connect(EntryPoint.HeadTcpEndPoint);
            }
            catch (SocketException exc)
            {
                MessageBox.Show("Head-server is unavailable");
            }
            
            if (to_head_client.Connected)
            {
                to_head_client.Send(ClientToHeadServerMessage.ReqServersList);
                var response = to_head_client.Receive<AllServersList>();
                if (response != null)
                {
                    if (response.ServersList.Count == 0)
                    {
                        MessageBox.Show("Absolutely no game servers running. Game-Servers must register at Head-server first ");
                    }
                    else
                    {
                        KnownActiveGameServers = response.ServersList;
                        Frontend.SetServersList(KnownActiveGameServers);
                    }
                    
                }
                to_head_client.Close();
            }
            
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
