using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using CommonLibrary.Model.Common;

namespace CommonLibrary.Model.ServerSide
{
    public enum ServerStatus { Running, Stopped, Uninitialized, Initialized }

    public interface IServer : IDisposable
    {
        ServerStatus Status { get; }
        IPEndPoint Socket { get; }

        event EventHandler OnInitialization;
        event EventHandler OnTermination;
        event EventHandler<ThreadStateEventArgs> OnThreadStateChange;

        void Initialize();

        void Stop();

        void Resume();

        void Start();

        void ServerLoop();

    }
}
