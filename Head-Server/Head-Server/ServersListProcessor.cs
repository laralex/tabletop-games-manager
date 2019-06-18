using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Implementation.Networking.Serializing;
using CommonLibrary.Implementation.Networking.Tcp;
using CommonLibrary.Implementation.ServerSide;
using CommonLibrary.Model.ServerSide;

namespace HeadServer
{
    /// <summary>
    /// When head server receives TCP connection with request to give list of servers
    /// This class's method should be opened in new THREAD
    /// Class will send data asynchronously
    /// </summary>
    internal class ServersListProcessor
    {
        private TcpClient _client;
        List<GameServerEntry> _servers_list;
        public ServersListProcessor(TcpClient tcp_client, List<GameServerEntry> servers_list)
        {
            _client = tcp_client;
            _servers_list = servers_list;
        }

        public void ProcessConnection()
        {
            _client.Send(new AllServersList(_servers_list));
            _client.Close();
            return;
        }
    }
}
