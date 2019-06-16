using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using CommonLibrary.Model.Networking;

namespace CommonLibrary.Implementation.Networking.Draft
{
    public class NetworkSender<E> : INetworkSender<E>
    {
        public IPEndPoint Sender => throw new NotImplementedException();

        public IPEndPoint OwnEndPoint => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Send(byte[] data, AsyncCallback callback)
        {
            throw new NotImplementedException();
        }

        public void Send(E message, AsyncCallback callback)
        {
            throw new NotImplementedException();
        }

        public void Send(byte[] data)
        {
            throw new NotImplementedException();
        }

        public void Send(E message)
        {
            throw new NotImplementedException();
        }
    }
}
