using CommonLibrary.Model.Networking;
using System;
using System.Net;
using System.Net.Sockets;

namespace CommonLibrary.Implementation.Networking.Udp
{
    /// <summary>
    /// Static creation of UdpReceiver, UdpSender with immediate init 
    /// </summary>
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

    }
}
