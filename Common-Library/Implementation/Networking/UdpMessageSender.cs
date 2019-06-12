using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace CommonLibrary.Implementation.Networking
{
    class UdpMessageSender
    {
        protected IPEndPoint _remote_ips;
        protected AsyncCallback _async_callback;
    }
}
