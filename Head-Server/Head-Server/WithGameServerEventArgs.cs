using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HeadServer.DB;
using CommonLibrary.Model.ServerSide.HeadServerAndGameServer;
using CommonLibrary.Model.ServerSide;
using CommonLibrary.Model.Common;
using CommonLibrary.Implementation.ServerSide;

namespace HeadServer
{


    internal class MessageFromGameServerEventArgs : EventArgs
    {

        public ToHeadServerMessageType MessageType { get; }
        public GameServerEntry Server { get; }
        public MessageFromGameServerEventArgs(GameServerEntry server, ToHeadServerMessageType type)
        {
            Server = server;
            MessageType = type;
        }
    }

    internal class MessageToGameServerEventArgs : EventArgs
    {
        public ToGameServerMessageType MessageType { get; }
        public GameServerEntry Server { get; }
        public MessageToGameServerEventArgs(GameServerEntry server, ToGameServerMessageType type)
        {
            Server = server;
            MessageType = type;
        }

    }
       
}
