using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HeadServer.DB;
using CommonLibrary.Model.ServerSide;

namespace HeadServer
{

    internal class ThreadStateEventArgs : EventArgs
    {
        public ThreadStateType State { get; }
        public ThreadStateEventArgs(ThreadStateType state)
        {
            State = state;   
        }
    }

    internal class MessageFromGameServerEventArgs : EventArgs
    {

        public FromGameServerMessageType MessageType { get; }
        public DB.GameServer Server { get; }
        public MessageFromGameServerEventArgs(DB.GameServer server, FromGameServerMessageType type)
        {
            Server = server;
            MessageType = type;
        }
    }

    internal class MessageToGameServerEventArgs : EventArgs
    {
        public ToGameServerMessageType MessageType { get; }
        public DB.GameServer Server { get; }
        public MessageToGameServerEventArgs(DB.GameServer server, ToGameServerMessageType type)
        {
            Server = server;
            MessageType = type;
        }

    }
       
}
