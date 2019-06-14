using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonLibrary.Model.Application;
using CommonLibrary.Model.ServerSide.HeadServerAndGameServer;
using CommonLibrary.Model.ServerSide.ApplicationClientAndGameServer;
using ToGameServerMessageType = CommonLibrary.Model.ServerSide.ApplicationClientAndGameServer.ToGameServerMessageType;

namespace CommonLibrary.Model.ServerSide
{
    public class MessageFromHeadServerEventArgs : EventArgs
    {
        public ToGameServerMessageType MessageType { get; }
        public MessageFromHeadServerEventArgs(ToGameServerMessageType type)
        {
            MessageType = type;
        }
    }

    public class MessageToHeadServerEventArgs : EventArgs
    {
        public ToHeadServerMessageType MessageType { get; }
        public MessageToHeadServerEventArgs(ToHeadServerMessageType type)
        {
            MessageType = type;
        }
    }

    public class MessageFromUserEventArgs : EventArgs
    {

        public ToGameServerMessageType MessageType { get; }
        public IUser User { get; }
        public MessageFromUserEventArgs(IUser user, ToGameServerMessageType type)
        {
            User = user;
            MessageType = type;
        }
    }

    public class MessageToUserEventArgs : EventArgs
    {
        public ToApplicationClientMessageType MessageType { get; }
        public IUser User { get; }
        public MessageToUserEventArgs(IUser user, ToApplicationClientMessageType type)
        {
            User = user;
            MessageType = type;
        }

    }
}
