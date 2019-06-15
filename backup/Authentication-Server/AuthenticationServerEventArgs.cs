using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer;

namespace HeadServer.AuthenticationServer
{


    internal class MessageFromUserEventArgs : EventArgs
    {

        public ToHeadServerMessageType MessageType { get; }
        public DB.User User { get; }
        public MessageFromUserEventArgs(DB.User user, ToHeadServerMessageType type)
        {
            User = user;
            MessageType = type;
        }
    }

    internal class MessageToUserEventArgs : EventArgs
    {
        public ToApplicationClientMessageType MessageType { get; }
        public DB.User User { get; }
        public MessageToUserEventArgs(DB.User user, ToApplicationClientMessageType type)
        {
            User = user;
            MessageType = type;
        }

    }
}
