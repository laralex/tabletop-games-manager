using System;
using System.Net;
using CommonLibrary.Implementation.Games;
using CommonLibrary.Model.Application;

namespace CommonLibrary.Model.ServerSide
{
    /// <summary>
    /// Game Server minimal functionality
    /// - Managing users connections
    /// - Managing game state
    /// - Events on this
    /// </summary>
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
