using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;

namespace CommonLibrary.Model.ServerSide
{
    public enum ServerStatus { Running, Stoped, Uninitialized }

    public interface IServer : IDisposable
    {
        ServerStatus Status { get; }
        IPEndPoint Socket { get; }

        void Initialize();

        void Pause();

        void Resume();

    }
}
