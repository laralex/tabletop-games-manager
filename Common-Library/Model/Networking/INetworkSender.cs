using System;
using System.Net;

namespace CommonLibrary.Model.Networking
{
    /// <summary>
    /// Entity is able to send some class instance by network
    /// </summary>
    /// <typeparam name="E"></typeparam>
    public interface INetworkSender<E> : IDisposable
    {
        IPEndPoint OwnEndPoint { get; }
        void Send(byte[] data);
        void Send(E message);

    }
}
