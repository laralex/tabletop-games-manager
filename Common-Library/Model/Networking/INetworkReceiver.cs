using System;
using System.Net;

namespace CommonLibrary.Model.Networking
{
    /// <summary>
    /// Entity is able to receive some class instance by network
    /// </summary>
    /// <typeparam name="E"></typeparam>
    public interface INetworkReceiver<E> : IDisposable
    {
        IPEndPoint RemoteEndPoint { get; }
        E Receive();
    }
}
