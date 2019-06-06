using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using CommonLibrary.Model.Networking;

namespace CommonLibrary.Implementation.Networking
{
    public class NetworkSender : INetworkSender
    {
        public IPEndPoint Sender => throw new NotImplementedException();

        public void Send(byte[] data, AsyncCallback callback)
        {
            throw new NotImplementedException();
        }

        public void Send(string message, AsyncCallback callback)
        {
            throw new NotImplementedException();
        }
    }
}
