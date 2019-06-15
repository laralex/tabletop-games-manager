using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CommonLibrary.Model.Networking
{
    public interface INetworkReceiver<E> : IDisposable
    {
        IPEndPoint RemoteSenderSocket { get; }
        E Read();
    }
}
