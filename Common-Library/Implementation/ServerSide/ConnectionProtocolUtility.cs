
using CommonLibrary.Implementation.Networking.Tcp;
using CommonLibrary.Model.ServerSide;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace CommonLibrary.Implementation.ServerSide
{
    public static class ConnectionProtocolUtility
    {
        public static bool SendGreetings(TcpClient client, IPEndPoint to_whom, SubsystemIdentifier subsystem)
        {
            // wait release of socket
            int sleep_timer = 0;
            while (client.Connected && sleep_timer < 50)
            {
                Thread.Sleep(50);
                ++sleep_timer;
            }

            try
            {
                client.Connect(to_whom);
            }
            catch (SocketException)
            {
                return false;
            }

            if (!client.Connected)
            {
                return false;
            }
            client.Send(subsystem);
            return true;
        }

        public static bool SendGoodbyes(TcpClient client)
        {
            return true;
        }

    }
}
