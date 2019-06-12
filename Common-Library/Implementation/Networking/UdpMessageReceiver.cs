using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CommonLibrary.Implementation.Networking
{
    public class UdpMessageReceiver
    {
        public UdpClient Listener { get; }
        public IPEndPoint RemoteIP { get => _remote_ips; }
        public UdpMessageReceiver(int listening_port)
        {
            _remote_ips = new IPEndPoint(IPAddress.Any, listening_port);
            Listener = new UdpClient(RemoteIP);

            _async_callback = new AsyncCallback(ReceiveText);
        }

        protected void ReceiveText(IAsyncResult result)
        {
            byte[] received_raw = Listener.EndReceive(result, ref _remote_ips);
            string received = Encoding.UTF8.GetString(received_raw);
            Listener.BeginReceive(_async_callback, null);

            //this.Invoke
        }

        protected IPEndPoint _remote_ips;
        protected AsyncCallback _async_callback;
    }

    public struct UdpState {
        public UdpClient Client;
        public IPEndPoint Remote;
        public UdpState(UdpClient client, IPEndPoint remote)
        {
            Client = client;
            Remote = remote;
        }
    }

}
