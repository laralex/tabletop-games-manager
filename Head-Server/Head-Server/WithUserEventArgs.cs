using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Implementation.ServerSide.Authentication;
using CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer;

namespace HeadServer
{


    internal class MessageFromUserEventArgs : EventArgs
    {

        public ToHeadServerMessageType MessageType { get; }
        public UserEntry User { get; }
        public MessageFromUserEventArgs(UserEntry user, ToHeadServerMessageType type)
        {
            User = user;
            MessageType = type;
        }
    }

    internal class MessageToUserEventArgs : EventArgs
    {
        public ToApplicationClientMessageType MessageType { get; }
        public UserEntry User { get; }
        public MessageToUserEventArgs(UserEntry user, ToApplicationClientMessageType type)
        {
            User = user;
            MessageType = type;
        }

    }
}
