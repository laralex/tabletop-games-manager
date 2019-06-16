using CommonLibrary.Model.Networking;
using System;
using System.Net;
using System.Net.Sockets;

namespace CommonLibrary.Implementation.Networking.Tcp
{

    /// <summary>
    /// Static creation of TcpClient and immediate connection
    /// </summary>
    public static class TcpNetworkFactory
    {
        public static INetworkMessenger<TE> MakeTcpMessanger<TE>(IPAddress address, int port)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(address, port);
                return new TcpMessenger<TE>(client);
            }
            catch (SocketException e)
            {
                Console.WriteLine("!> Socket Exception while creating Tcp-Messenger: " + e.Message);
            }
            return null;
        }

    }
}
