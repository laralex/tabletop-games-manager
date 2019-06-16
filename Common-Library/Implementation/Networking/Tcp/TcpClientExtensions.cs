using CommonLibrary.Implementation.Networking.Serializing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Tcp
{
    public static class TcpClientExtensions
    {
        static public E Receive<E>(this TcpClient client)
        {
            var stream = client.GetStream();
            if (!stream.CanRead)
            {
                return default(E);
            }
            using (var memory = new MemoryStream())
            {
                byte[] buffer = new byte[1024];
                int last_read_size = 0;
                // Loop through data and read
                do
                {
                    last_read_size = stream.Read(buffer, 0, buffer.Length);
                    memory.Write(buffer, 0, last_read_size);
                } while (last_read_size == buffer.Length);
                byte[] all_data = memory.ToArray();
                return BinaryMessageFactory.Deserialize<E>(all_data);
            }
        }

        static public void Send(this TcpClient client, byte[] data)
        {
            var stream = client.GetStream();
            {
                stream.Write(data, 0, data.Length);
                stream.Flush();
            }
        }

        static public void Send<E>(this TcpClient client, E message)
        {
            byte[] data = message.Serialize();
            Send(client, data);
        }
    }
}
