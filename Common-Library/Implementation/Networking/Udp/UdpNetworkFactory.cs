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
        public static INetworkReceiver<TE> MakeUdpReader<TE>(int port)
        {
            UdpClient client = new UdpClient(port);
            return new UdpReceiver<TE>(client);
        }

        public static INetworkSender<TE> MakeUdpWriter<TE>(IPAddress address, int port)
        {
            UdpClient client = new UdpClient();
            client.Connect(address, port);
            return new UdpSender<TE>(client);
        }

        public static INetworkSender<TE> MakeBroadcast<TE>(int port)
        {
            UdpClient client = new UdpClient { EnableBroadcast = true };
            // TODO
            //client.Connect(IPAddress.Parse("192.168.13.255"), port);
            return new UdpSender<TE>(client);
        }
    }
}
