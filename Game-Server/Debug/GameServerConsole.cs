using System;

using CommonLibrary.Model.ServerSide;
using CommonLibrary.Model.Common;
using CommonLibrary.Implementation.Common;

namespace GameServer.Debug
{

    /// <summary>
    /// Wrapper of debugging console
    /// It listens to events on game server and prints log in console
    /// </summary>

    internal class GameServerConsole
    {
        public GameServerConsole(IGameServer server)
        {
            if (server == null)
            {
                return;
            }
            server.OnInitialization += InitMessage;
            server.OnThreadStateChange += NetworkThreadMessage;
            server.OnTermination += TerminationMessage;
            server.OnMessageFromUser += UserMessage;
            server.OnMessageToUser += UserMessage;
            server.OnMessageToHeadServer += HeadServerMessage;
            server.OnMessageFromHeadServer += HeadServerMessage;
        }

        public void HeadServerMessage(object sender, MessageFromHeadServerEventArgs e)
        {
            IGameServer server = sender as IGameServer;
            Console.WriteLine("\tGame <-- Head : {0} : {1}", StringifyType(e.MessageType), server.Name);
        }

        public void HeadServerMessage(object sender, MessageToHeadServerEventArgs e)
        {
            IGameServer server = sender as IGameServer;
            Console.WriteLine("\tGame <-- Head : {0} : {1}", StringifyType(e.MessageType), server.Name);
        }

        public void InitMessage(object sender, EventArgs args)
        {
            IGameServer server = sender as IGameServer;
            Console.WriteLine("\tGame server: INIT");
        }

        public void NetworkThreadMessage(object sender, ThreadStateEventArgs args)
        {
            IGameServer server = sender as IGameServer;
            Console.WriteLine("\tGame server: NETWORK THREAD " + StringifyType(args.State));
        }

        public void UserMessage(object sender, MessageFromUserEventArgs args)
        {
            IGameServer server = sender as IGameServer;
            Console.WriteLine("\tUser --> Game : {0} : U= {1} : G= {2}", StringifyType(args.MessageType), args.User.Name, server.Name );
        }

        public void UserMessage(object sender, MessageToUserEventArgs args)
        {
            IGameServer server = sender as IGameServer;
            Console.WriteLine("\tUser <-- Game : {0} : U= {1} : G= {2}", StringifyType(args.MessageType), args.User.Name, server.Name);
        }


        public void TerminationMessage(object sender, EventArgs args)
        {
            IGameServer server = sender as IGameServer;
            Console.WriteLine("\tGame server: TERMINATE");
        }

        public void StartGameCommand()
        {
            Console.Write("Start? > ");
            Console.ReadLine();
        }

        public void DebugThreadLoop()
        {
            while (true)
            {
                
            }
        }

        private string StringifyType(ClientToGameServerMessage type)
        {
            switch (type)
            {
                case ClientToGameServerMessage.ReqConnect:
                    return "REQUEST CONNECT";
                case ClientToGameServerMessage.ReqConfig:
                    return "REQUEST CONFIG";
                case ClientToGameServerMessage.ReqDisconnect:
                    return "REQUEST DISCONNECT";
                case ClientToGameServerMessage.SelectDie:
                    return "REQUEST SELECT DIE";
                case ClientToGameServerMessage.GetScoreOfSelection:
                    return "CALCULATE SCORE OF SELECTED";
                case ClientToGameServerMessage.SubmitDice:
                    return "SUBMIT DICE";
                case ClientToGameServerMessage.EndTurn:
                    return "END OF TURN";
                case ClientToGameServerMessage.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }

        private string StringifyType(ThreadState type)
        {
            switch (type)
            {
                case ThreadState.Begin:
                    return "BEGIN";
                case ThreadState.End:
                    return "END";
                case ThreadState.Resume:
                    return "RESUME";
                case ThreadState.Stop:
                    return "STOP";
                case ThreadState.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }

        private string StringifyType(GameServerToClientMessage type)
        {
            switch (type)
            {
                case GameServerToClientMessage.ReqDisconnect:
                    return "REQUEST DISCONNECT";
                case GameServerToClientMessage.UseConfig:
                    return "USE THIS CONFIG";
                case GameServerToClientMessage.AckConnect:
                    return "I CONNECT YOU";
                case GameServerToClientMessage.TurnSwitch:
                    return "TURN SWITCH";
                case GameServerToClientMessage.Reroll:
                    return "REROLL";
                case GameServerToClientMessage.YourTurn:
                    return "YOUR TURN";
                case GameServerToClientMessage.Failure:
                    return "FAILURE OF TURN";
                case GameServerToClientMessage.PlayerKicked:
                    return "PLAYER KICKED";
                case GameServerToClientMessage.GameEnd:
                    return "GAME ENDED";
                case GameServerToClientMessage.GameStart:
                    return "GAME STARTED";
                case GameServerToClientMessage.GameShutdown:
                    return "GAME SHUTDOWN";
                case GameServerToClientMessage.UseScoreOfSelection:
                    return "USE SCORE OF SELECTION";
                case GameServerToClientMessage.DiceSubmitted:
                    return "DICE SUBMITTED";
                case GameServerToClientMessage.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }

        private string StringifyType(HeadToGameServerMessage type)
        {
            switch (type)
            {
                case HeadToGameServerMessage.AckRegister:
                    return "ACK YOUR REGISTER";
                case HeadToGameServerMessage.AckMyData:
                    return "ACK YOUR DATA";
                case HeadToGameServerMessage.AckDetach:
                    return "ACK YOUR DETACH";
                case HeadToGameServerMessage.AckStatusUpdate:
                    return "ACK STATUS UPD REQ";
                case HeadToGameServerMessage.AckStatusData:
                    return "ACK STATUS UPD DATA";
                case HeadToGameServerMessage.DenyRegister:
                    return "DENY YOUR REGISTER";
                case HeadToGameServerMessage.DenyMyData:
                    return "DENY YOUR DATA";
                case HeadToGameServerMessage.DenyStatusUpdate:
                    return "DENY STATUS UPD REQ";
                case HeadToGameServerMessage.DenyStatusData:
                    return "DENY STATUS UPD DATA";
                case HeadToGameServerMessage.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }

        private string StringifyType(GameToHeadServerMessage type)
        {
            switch (type)
            {
                case GameToHeadServerMessage.ReqRegister:
                    return "REQ MY REGISTER";
                case GameToHeadServerMessage.ReqDetach:
                    return "REQ MY DETACH";
                case GameToHeadServerMessage.ReqStatusUpdate:
                    return "REQ STATUS UPD";
                case GameToHeadServerMessage.UseMyData:
                    return "REQ USE MY DATA";
                case GameToHeadServerMessage.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }
    }
}
