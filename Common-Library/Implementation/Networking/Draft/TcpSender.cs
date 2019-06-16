using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using CommonLibrary.Model.Networking;
using CommonLibrary.Implementation.Networking.Serializing;

using CommonLibrary.Implementation.Networking;
namespace CommonLibrary.Implementation.Networking.Tcp
{
    // NOTE: Deprecated - see TcpMessenger.cs

    /*
    public class TcpSender<E> : INetworkSender<E>
    {
        public IPEndPoint OwnEndPoint { get; private set; }
        public IPEndPoint RemoteEndPoint { get; set; }
        public TcpSender(TcpClient client)
        {
            //_tcp_client = client;
        }
        public void Dispose()
        {
            //_tcp_client.Close();
        }

        public void Send(byte[] data)
        {
            //_tcp_client.Client.SendAllData(data);
        }

        public void Send(E message)
        {
            //byte[] data = message.Serialize();
            //Send(data);
        }

        private TcpClient _tcp_client;
    }
    */
}
