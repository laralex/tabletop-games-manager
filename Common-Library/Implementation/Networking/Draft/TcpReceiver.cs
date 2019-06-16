using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using CommonLibrary.Model.Networking;

using CommonLibrary.Implementation.Networking.Serializing;

namespace CommonLibrary.Implementation.Networking.Tcp
{

    // NOTE: Deprecated - see TcpMessenger.cs

    /*public class TcpReceiver<E> : INetworkReceiver<E>
    {
        public IPEndPoint RemoteEndPoint => _remote_sender_end_point;
        public TcpReceiver(TcpClient client)
        {
            //_tcp_client = client;
        }

        public void Dispose()
        {
            //_tcp_client.Close();
        }

        public E Read()
        {
            //byte[] data = _tcp_client.Receive(ref _remote_sender_end_point);
            //return BinaryMessageFactory.Deserialize<E>(data);
        }

        private readonly TcpClient _tcp_client;
        private IPEndPoint _remote_sender_end_point;
        
    }
    */
}
