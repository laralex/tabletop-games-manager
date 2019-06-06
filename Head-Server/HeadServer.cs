using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

using CommonLibrary;
using CommonLibrary.Implementation.Networking;
using CommonLibrary.Model;
using CommonLibrary.Model.Networking;
using CommonLibrary.Model.ServerSide;

using HeadServer.EntityFramework;
namespace HeadServer
{
    

    public class HeadServer : IServer, INetworkReceiver, INetworkSender
    {
        public ServerStatus Status { get; internal set; }
        public IPEndPoint Socket { get; internal set; }

        public HeadServer()
        {
            this.Status = ServerStatus.Uninitialized;
        }

        public void Initialize()
        {
            this.Status = ServerStatus.Running;
        }

        public void Pause()
        {
            if (this.Status == ServerStatus.Running)
            {
                this.Status = ServerStatus.Stoped;
            }
        }

        public void Resume()
        {
            if (this.Status == ServerStatus.Stoped)
            {
                this.Status = ServerStatus.Running;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private EntityFramework.User[] RecentUsers;
        private EntityFramework.GameServer[] RegisteredServers;
    }
}
