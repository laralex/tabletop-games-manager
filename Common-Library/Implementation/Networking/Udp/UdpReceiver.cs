﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using CommonLibrary.Model.Networking;

using CommonLibrary.Implementation.Networking.Serializing;

namespace CommonLibrary.Implementation.Networking.Udp
{
    public class UdpReceiver<E> : INetworkReceiver<E>
    {
        
        public IPEndPoint RemoteSenderSocket => _remote_sender_socket;
        public UdpReceiver(UdpClient client)
        {
            _udp_client = client;
        }

        public void Dispose()
        {
            _udp_client.Close();
        }

        public E Read()
        {
            byte[] data = _udp_client.Receive(ref _remote_sender_socket);
            return BinaryMessageFactory.Deserialize<E>(data);
        }

        private readonly UdpClient _udp_client;
        private IPEndPoint _remote_sender_socket;

    }
}