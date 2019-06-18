using CommonLibrary.Implementation.Networking.Tcp;
using CommonLibrary.Model.ServerSide;
using System;
using System.Net.Sockets;
using System.Threading;

namespace HeadServer
{
    internal class IncommingTcpDispatcher
    {
        public IncommingTcpDispatcher(HeadServer head)
        {
            _head_server = head;
        }
        public void DispatchClient(TcpClient client)
        {
            var subsystem_info = client.Receive<SubsystemIdentifier>().Identifier;
            Thread clientThread = null;
            while (client.Available == 0) { Thread.Sleep(50); }
            if (subsystem_info == "GAME_CLIENT")
            {      
                var request = client.Receive<ClientToHeadServerMessage>();
                switch (request)
                {
                    case ClientToHeadServerMessage.ReqServersList:
                        var servers_list = _head_server.DbServer.SelectActiveGameServers();
                        var servers_list_processor = new ServersListProcessor(client, servers_list);
                        clientThread = new Thread(
                            new ThreadStart(servers_list_processor.ProcessConnection)
                        );
                        break;
                    case ClientToHeadServerMessage.ReqLogIn:
                        var to_app_message_processor = new AuthenticationConnectionProcessor(
                            client,
                            _head_server.AuthServer
                        );
                        clientThread = new Thread(
                            new ThreadStart(to_app_message_processor.ProcessLogin)
                        );
                        break;
                    case ClientToHeadServerMessage.ReqSignUp:
                        to_app_message_processor = new AuthenticationConnectionProcessor(
                            client,
                            _head_server.AuthServer
                        );
                        clientThread = new Thread(
                            new ThreadStart(to_app_message_processor.ProcessSignup)
                        );
                        break;
                }
            }
            else if (subsystem_info == "GAME_SERVER") {
                var request = client.Receive<GameToHeadServerMessage>();
                switch (request)
                {
                    case GameToHeadServerMessage.ReqRegister:
                        var server_registration_processor = new ServerRegistrationProcessor(
                            client, 
                            _head_server
                        );
                        clientThread = new Thread(
                            new ThreadStart(server_registration_processor.ProcessServerRegister)
                        );
                        break;
                }
            }
            clientThread?.Start();
        }

        private HeadServer _head_server;
    }
}
