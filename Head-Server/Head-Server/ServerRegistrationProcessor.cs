using CommonLibrary.Implementation.Networking.Tcp;
using CommonLibrary.Implementation.ServerSide;
using CommonLibrary.Model.ServerSide;
using HeadServer.DB;
using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace HeadServer
{
    internal class ServerRegistrationProcessor
    {
        private TcpClient _client;
        private HeadServer _head_server;
        public ServerRegistrationProcessor(TcpClient tcp_client, HeadServer head_server)
        {
            _client = tcp_client;
            _head_server = head_server;
        }

        public void ProcessServerRegister()
        {
            _client.Send(HeadToGameServerMessage.AckRegister);
            while (_client.Available == 0) { Thread.Sleep(100); }
            var new_server_options = _client.Receive<GameServerEntry>();
            bool result = _head_server.TryRegisterServer(
                ((IPEndPoint)(_client.Client.RemoteEndPoint)).Address,
                new_server_options
            );
            _client.Send(result ? HeadServerToClientMessage.AckLogIn : HeadServerToClientMessage.DenyLogIn);
            _client.Close();
            return;
        }
    }
}
