using CommonLibrary.Model.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Udp
{
    public static class UdpNetworkFactory
    {
        public static INetworkReceiver<TE> MakeUdpReceiver<TE>(int port)
        {
            try
            {
                UdpClient client = new UdpClient(port);
                return new UdpReceiver<TE>(client);
            }
            catch (SocketException e)
            {
                Console.WriteLine("!> Socket Exception while creating Udp-Receiver on local port: " + e.Message);
            }
            return null;
        }

        public static INetworkSender<TE> MakeUdpSender<TE>(IPAddress address, int port)
        {
            UdpClient client = new UdpClient();
            try
            {
                client.Connect(address, port);
                return new UdpSender<TE>(client);
            }
            catch (SocketException e)
            {
                Console.WriteLine("!> Socket Exception while connection of Udp-Sender: " + e.Message);
            }
            return null;
        }

        /*
        public static INetworkSender<TE> MakeBroadcast<TE>(int port)
        {
            UdpClient client = new UdpClient { EnableBroadcast = true };
            // TODO
            client.Connect(IPAddress.Loopback, port);
            return new UdpSender<TE>(client);
        }
        */
    }
}
