using CommonLibrary.Model.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Tcp
{
    public static class TcpNetworkFactory
    {
        /*public static INetworkReceiver<TE> MakeTcpReceiver<TE>(IPAddress address, int port)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(address, port);
                return new TcpReceiver<TE>(client);
            }
            catch (SocketException e)
            {
                Console.WriteLine("!> Socket Exception while creating Tcp-Receiver: " + e.Message);
            }
            return null;
        }
        */

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

        /*
        public static INetworkSender<TE> MakeBroadcast<TE>(int port)
        {
            TcpClient client = new TcpClient();
            // TODO
            //client.Connect(IPAddress.Parse("192.168.13.255"), port);
            return new TcpSender<TE>(client);
        }
        */
    }
}
