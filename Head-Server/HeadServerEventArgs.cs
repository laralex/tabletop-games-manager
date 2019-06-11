using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HeadServer.DB;

namespace HeadServer
{
    internal enum ThreadStateType
    {
        Begin,
        Resume,
        Stop,
        End
    }
    internal enum FromGameServerMessageType
    {
        ReqRegister,
        ReqDetach,
        ReqStatusUpdate,
        UseMyData
        //UseStatus
    }

    internal enum ToGameServerMessageType
    {
        AckRegister,
        AckMyData,
        AckDetach,
        AckStatusUpdate,
        AckStatusData,
        DenyRegister,
        DenyMyData,
        DenyStatusUpdate,
        DenyStatusData
    }
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
