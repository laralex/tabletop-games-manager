using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace CommonLibrary.Implementation.Networking
{
    static class SocketExtentions
    {
        public static byte[] ReceiveAllData(this Socket socket)
        {
            // Create cumulative buffer
            using (MemoryStream memory = new MemoryStream())
            {
                // Create reading buffer
                byte[] buffer = new byte[1024];
                int last_buffer_data_size;
                // Loop through data and read
                while (socket.Available > 0)
                {
                    last_buffer_data_size = socket.Receive(buffer);
                    memory.Write(buffer, 0, last_buffer_data_size);
                }
                memory.Flush();
                // Return cumulative binary data 
                return memory.ToArray();
            }
        }

        public static string ReceiveText(this Socket socket)
        {
            // Fetch binary data from connection
            byte[] data = socket.ReceiveAllData();
            // Convert to c# string
            return Encoding.UTF8.GetString(data);
        }

        public static void SendAllData(this Socket socket, byte[] big_data)
        {
            int data_idx = 0;
            while (data_idx < big_data.Length && socket.Connected)
            { 
                data_idx += socket.Send(
                    buffer: big_data, 
                    offset: data_idx, 
                    size: big_data.Length - data_idx, 
                    socketFlags: SocketFlags.Partial);
            }
        }

        public static void SendAllText(this Socket socket, string big_str)
        {
            byte[] data = Encoding.UTF8.GetBytes(big_str);
            socket.SendAllData(data);
        }
    }
}
