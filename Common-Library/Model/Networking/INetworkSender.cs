using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace CommonLibrary.Model.Networking
{
    public interface INetworkSender
    {
        IPEndPoint Sender { get; }
        void Send(byte[] data, AsyncCallback callback);
        void Send(string message, AsyncCallback callback);

    }
}
