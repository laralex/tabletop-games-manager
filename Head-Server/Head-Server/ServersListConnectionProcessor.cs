using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Implementation.Networking.Serializing;
using CommonLibrary.Implementation.Networking.Tcp;
using CommonLibrary.Implementation.ServerSide;
using CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer;

namespace HeadServer
{
    internal class ServersListConnectionProcessor
    {
        private TcpClient _client;
        List<GameServerEntry> _servers_list;
        public ServersListConnectionProcessor(TcpClient tcp_client, List<GameServerEntry> servers_list)
        {
            _client = tcp_client;
            _servers_list = servers_list;
        }

        public void ProcessConnection()
        {
            _client.Send(new ServersListMessage(_servers_list));
            _client.Close();
            return;
        }
    }
}
