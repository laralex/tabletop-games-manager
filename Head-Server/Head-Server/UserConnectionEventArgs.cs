using System;
using CommonLibrary.Implementation.ServerSide.Authentication;
using CommonLibrary.Model.ServerSide;

namespace HeadServer
{

    /// <summary>
    /// These Event args are attached to events on head server
    /// when user interconnection orrurs
    /// </summary>
    internal class MessageFromUserEventArgs : EventArgs
    {

        public ClientToHeadServerMessage MessageType { get; }
        public UserEntry User { get; }
        public MessageFromUserEventArgs(UserEntry user, ClientToHeadServerMessage type)
        {
            User = user;
            MessageType = type;
        }
    }

    internal class MessageToUserEventArgs : EventArgs
    {
        public HeadServerToClientMessage MessageType { get; }
        public UserEntry User { get; }
        public MessageToUserEventArgs(UserEntry user, HeadServerToClientMessage type)
        {
            User = user;
            MessageType = type;
        }

    }
}
