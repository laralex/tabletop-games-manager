using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadServer.AuthenticationServer
{
    internal enum FromUserMessageType
    {
        ReqLogIn,
        ReqLogOut,
        ReqSignUp,
        ReqServersList,
        UseMyData
    }
    internal enum ToUserMessageType
    {
        AckLogIn,
        AckLogOut,
        AckSignUp,
        AckMyData,
        DenyLogIn,
        DenySignUp,
        DenyServerList,
        UseServerList
    }

    internal class MessageFromUserEventArgs : EventArgs
    {

        public FromUserMessageType MessageType { get; }
        public DB.User User { get; }
        public MessageFromUserEventArgs(DB.User user, FromUserMessageType type)
        {
            User = user;
            MessageType = type;
        }
    }

    internal class MessageToUserEventArgs : EventArgs
    {
        public ToUserMessageType MessageType { get; }
        public DB.User User { get; }
        public MessageToUserEventArgs(DB.User user, ToUserMessageType type)
        {
            User = user;
            MessageType = type;
        }

    }
}
