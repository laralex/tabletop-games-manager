using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HeadServer.DB.Context;
using CommonLibrary.Model.ServerSide;
using System.Net;

namespace HeadServer.DB
{
    internal class DatabaseServer : IServer
    {
        public MainContext Context { get; internal set; }

        public ServerStatus Status { get; internal set; }

        public IPEndPoint Socket { get; internal set; }

        public DatabaseServer()
        {
            Status = ServerStatus.Uninitialized;
        }

        public void Initialize()
        {
            Context = new MainContext();

            Status = ServerStatus.Initialized;
        }

        public void Initialize(IPEndPoint socket)
        {
            Socket = socket;

            Initialize();
        }

        public void Stop()
        {
            Status = ServerStatus.Stopped;
        }

        public void Start()
        {
            Status = ServerStatus.Running;
        }

        public void Dispose()
        {
            Context = null;
            Socket = null;

            Status = ServerStatus.Uninitialized;
        }

        public void ServerLoop()
        {
            
        }
    }
}
