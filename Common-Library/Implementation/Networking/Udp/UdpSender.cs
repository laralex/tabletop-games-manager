using System.Net;
using System.Net.Sockets;
using CommonLibrary.Model.Networking;
using CommonLibrary.Implementation.Networking.Serializing;

namespace CommonLibrary.Implementation.Networking.Udp
{
    /// <summary>
    /// UdpClient connected to remote host to send datagrams
    /// </summary>
    class UdpSender<E> : INetworkSender<E>
    {
        public IPEndPoint OwnEndPoint { get; private set; }
        public IPEndPoint RemoteEndPoint { get; set; }
        public UdpSender(UdpClient client)
        {
            _udp_client = client;
        }
        public void Dispose()
        {
            _udp_client.Close();
        }

        public void Send(byte[] data)
        {
            _udp_client.Send(data, data.Length);
        }

        public void Send(E message)
        {
            byte[] data = message.Serialize();
            Send(data);
        }

        private UdpClient _udp_client;
    }
}
