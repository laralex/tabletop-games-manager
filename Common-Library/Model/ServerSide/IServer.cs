using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;

namespace CommonLibrary.Model.ServerSide
{
    public enum ServerStatus { Running, Stopped, Uninitialized, Initialized }

    public interface IServer : IDisposable
    {
        ServerStatus Status { get; }
        IPEndPoint Socket { get; }

        void Initialize();

        void Stop();

        void Start();

        void ServerLoop();

    }
}
