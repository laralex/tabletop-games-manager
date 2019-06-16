using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CommonLibrary.Implementation.Networking.Tcp
{
    /*public class TcpMessageReceiver
    {
        public TcpClient Listener { get; }
        public IPEndPoint RemoteIP { get => _remote_ips; }
        public TcpMessageReceiver(int listening_port)
        {
            _remote_ips = new IPEndPoint(IPAddress.Any, listening_port);
            Listener = new TcpClient(RemoteIP);

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

    public struct TcpState {
        public TcpClient Client;
        public IPEndPoint Remote;
        public TcpState(TcpClient client, IPEndPoint remote)
        {
            Client = client;
            Remote = remote;
        }
    }
    */

}
