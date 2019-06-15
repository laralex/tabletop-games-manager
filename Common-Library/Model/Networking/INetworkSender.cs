using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace CommonLibrary.Model.Networking
{
    public interface INetworkSender<E> : IDisposable
    {
        IPEndPoint OwnSocket { get; }
        void Send(byte[] data);
        void Send(E message);

    }
}
