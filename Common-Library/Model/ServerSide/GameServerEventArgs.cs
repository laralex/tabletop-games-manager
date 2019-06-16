using System;
using CommonLibrary.Model.Application;

namespace CommonLibrary.Model.ServerSide
{
    /// <summary>
    /// Event Args for GameServer's messaging events
    /// </summary>
    public class MessageFromHeadServerEventArgs : EventArgs
    {
        public ClientToGameServerMessage MessageType { get; }
        public MessageFromHeadServerEventArgs(ClientToGameServerMessage type)
        {
            MessageType = type;
        }
    }

    public class MessageToHeadServerEventArgs : EventArgs
    {
        public GameToHeadServerMessage MessageType { get; }
        public MessageToHeadServerEventArgs(GameToHeadServerMessage type)
        {
            MessageType = type;
        }
    }

    public class MessageFromUserEventArgs : EventArgs
    {

        public ClientToGameServerMessage MessageType { get; }
        public IUser User { get; }
        public MessageFromUserEventArgs(IUser user, ClientToGameServerMessage type)
        {
            User = user;
            MessageType = type;
        }
    }

    public class MessageToUserEventArgs : EventArgs
    {
        public GameServerToClientMessage MessageType { get; }
        public IUser User { get; }
        public MessageToUserEventArgs(IUser user, GameServerToClientMessage type)
        {
            User = user;
            MessageType = type;
        }

    }
}
