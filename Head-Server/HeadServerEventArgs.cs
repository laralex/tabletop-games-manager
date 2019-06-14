using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HeadServer.DB;
using CommonLibrary.Model.ServerSide.HeadServerAndGameServer;
using CommonLibrary.Model.ServerSide;
using CommonLibrary.Model.Common;

namespace HeadServer
{


    internal class MessageFromGameServerEventArgs : EventArgs
    {

        public ToHeadServerMessageType MessageType { get; }
        public DB.GameServer Server { get; }
        public MessageFromGameServerEventArgs(DB.GameServer server, ToHeadServerMessageType type)
        {
            Server = server;
            MessageType = type;
        }
    }

    internal class MessageToGameServerEventArgs : EventArgs
    {
        public ToGameServerMessageType MessageType { get; }
        public DB.GameServer Server { get; }
        public MessageToGameServerEventArgs(DB.GameServer server, ToGameServerMessageType
            type)
        {
            Server = server;
            MessageType = type;
        }

    }
       
}
