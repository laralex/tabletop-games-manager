
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using CommonLibrary.Implementation.Games;
using CommonLibrary.Model.Application;
using CommonLibrary.Model.ServerSide.ApplicationClientAndGameServer;

namespace CommonLibrary.Model.ServerSide
{
    public interface IGameServer : IServer
    {
        GameType GameType { get; }
        GameOptions GameOptions { get; }
        string Name { get; }
        int MaximumPlayers { get; }
        int PlayersNumber { get; }
        
        event EventHandler<MessageFromHeadServerEventArgs> OnMessageToHeadServer;
        event EventHandler<MessageToHeadServerEventArgs> OnMessageFromHeadServer;
        event EventHandler<MessageFromUserEventArgs> OnMessageFromUser;
        event EventHandler<MessageToUserEventArgs> OnMessageToUser;

        bool ConnectUser(IUser user, IPEndPoint socket);
        bool DisconnectUser(IUser user);
        void StartNewGame();
        void ShutdownGame();
         

    }
}
