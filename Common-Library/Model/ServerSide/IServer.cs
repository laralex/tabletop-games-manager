using CommonLibrary.Implementation.Common;
using System;
using System.Net;

namespace CommonLibrary.Model.ServerSide
{
    public enum ServerStatus { Running, Stopped, Uninitialized, Initialized }

    /// <summary>
    /// Every Server's minimal functionality
    /// </summary>
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
