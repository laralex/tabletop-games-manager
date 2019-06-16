using System;

using CommonLibrary.Model.ServerSide;
using CommonLibrary.Implementation.ServerSide;

namespace HeadServer
{

    /// <summary>
    /// These Event args are attached to events on head server
    /// when game server interconnection orrurs
    /// </summary>
    internal class MessageFromGameServerEventArgs : EventArgs
    {

        public GameToHeadServerMessage MessageType { get; }
        public GameServerEntry Server { get; }
        public MessageFromGameServerEventArgs(GameServerEntry server, GameToHeadServerMessage type)
        {
            Server = server;
            MessageType = type;
        }
    }

    internal class MessageToGameServerEventArgs : EventArgs
    {
        public HeadToGameServerMessage MessageType { get; }
        public GameServerEntry Server { get; }
        public MessageToGameServerEventArgs(GameServerEntry server, HeadToGameServerMessage type)
        {
            Server = server;
            MessageType = type;
        }

    }
       
}
