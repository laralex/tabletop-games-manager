using CommonLibrary.Implementation.Networking.Serializing;
using CommonLibrary.Model.Networking;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Tcp
{
    public class TcpMessenger<E> : INetworkMessenger<E>
    {
        public IPEndPoint RemoteEndPoint => throw new NotImplementedException();

        public IPEndPoint OwnEndPoint => throw new NotImplementedException();

        public TcpMessenger(TcpClient client)
        {
            _tcp_client = client;
        }
        public void Dispose()
        {
            _data_stream?.Close();
            _tcp_client.Close();
        }

        public E Receive()
        {
            var stream = _tcp_client.GetStream();
            using (var memory = new MemoryStream())
            {
                byte[] buffer = new byte[1024];
                int last_read_size;
                // Loop through data and read
                while (stream.CanRead && _tcp_client.Available > 0)
                {
                    last_read_size = stream.Read(buffer, 0, buffer.Length);
                    memory.Write(buffer, 0, last_read_size);
                }
                byte[] all_data = memory.ToArray();
                return BinaryMessageFactory.Deserialize<E>(all_data);
            }
        }

        public void Send(byte[] data)
        {
            var stream = _tcp_client.GetStream();
            {
                stream.Write(data, 0, data.Length);
            }
        }

        public void Send(E message)
        {
            byte[] data = message.Serialize();
            Send(data);
        }

        private TcpClient _tcp_client;
        private NetworkStream _data_stream;
    }
}
