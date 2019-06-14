using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonLibrary.Model.ServerSide;

using CommonLibrary.Model.Common;
using CommonLibrary.Model.ServerSide.ApplicationClientAndGameServer;
using ToHeadServerMessageType = CommonLibrary.Model.ServerSide.HeadServerAndGameServer.ToHeadServerMessageType;
using ToGameServerFromHead = CommonLibrary.Model.ServerSide.HeadServerAndGameServer.ToGameServerMessageType;

namespace GameServer.Debug
{


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

        private void HeadServerMessage(object sender, MessageFromHeadServerEventArgs e)
        {
            IGameServer server = sender as IGameServer;
            Console.WriteLine("\tGame <-- Head : {0} : {1}", StringifyType(e.MessageType), server.Name);
        }

        private void HeadServerMessage(object sender, MessageToHeadServerEventArgs e)
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

        private string StringifyType(ToGameServerMessageType type)
        {
            switch (type)
            {
                case ToGameServerMessageType.ReqConnect:
                    return "REQUEST CONNECT";
                case ToGameServerMessageType.ReqConfig:
                    return "REQUEST CONFIG";
                case ToGameServerMessageType.ReqDisconnect:
                    return "REQUEST DISCONNECT";
                case ToGameServerMessageType.SelectDie:
                    return "REQUEST SELECT DIE";
                case ToGameServerMessageType.GetScoreOfSelection:
                    return "CALCULATE SCORE OF SELECTED";
                case ToGameServerMessageType.SubmitDice:
                    return "SUBMIT DICE";
                case ToGameServerMessageType.EndTurn:
                    return "END OF TURN";
                case ToGameServerMessageType.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }

        private string StringifyType(ThreadStateType type)
        {
            switch (type)
            {
                case ThreadStateType.Begin:
                    return "BEGIN";
                case ThreadStateType.End:
                    return "END";
                case ThreadStateType.Resume:
                    return "RESUME";
                case ThreadStateType.Stop:
                    return "STOP";
                case ThreadStateType.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }

        private string StringifyType(ToApplicationClientMessageType type)
        {
            switch (type)
            {
                case ToApplicationClientMessageType.ReqDisconnect:
                    return "REQUEST DISCONNECT";
                case ToApplicationClientMessageType.UseConfig:
                    return "USE THIS CONFIG";
                case ToApplicationClientMessageType.AckConnect:
                    return "I CONNECT YOU";
                case ToApplicationClientMessageType.TurnSwitch:
                    return "TURN SWITCH";
                case ToApplicationClientMessageType.Reroll:
                    return "REROLL";
                case ToApplicationClientMessageType.YourTurn:
                    return "YOUR TURN";
                case ToApplicationClientMessageType.Failure:
                    return "FAILURE OF TURN";
                case ToApplicationClientMessageType.PlayerKicked:
                    return "PLAYER KICKED";
                case ToApplicationClientMessageType.GameEnd:
                    return "GAME ENDED";
                case ToApplicationClientMessageType.GameStart:
                    return "GAME STARTED";
                case ToApplicationClientMessageType.GameShutdown:
                    return "GAME SHUTDOWN";
                case ToApplicationClientMessageType.UseScoreOfSelection:
                    return "USE SCORE OF SELECTION";
                case ToApplicationClientMessageType.DiceSubmitted:
                    return "DICE SUBMITTED";
                case ToApplicationClientMessageType.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }

        private string StringifyType(ToGameServerFromHead type)
        {
            switch (type)
            {
                case ToGameServerFromHead.AckRegister:
                    return "ACK YOUR REGISTER";
                case ToGameServerFromHead.AckMyData:
                    return "ACK YOUR DATA";
                case ToGameServerFromHead.AckDetach:
                    return "ACK YOUR DETACH";
                case ToGameServerFromHead.AckStatusUpdate:
                    return "ACK STATUS UPD REQ";
                case ToGameServerFromHead.AckStatusData:
                    return "ACK STATUS UPD DATA";
                case ToGameServerFromHead.DenyRegister:
                    return "DENY YOUR REGISTER";
                case ToGameServerFromHead.DenyMyData:
                    return "DENY YOUR DATA";
                case ToGameServerFromHead.DenyStatusUpdate:
                    return "DENY STATUS UPD REQ";
                case ToGameServerFromHead.DenyStatusData:
                    return "DENY STATUS UPD DATA";
                case ToGameServerFromHead.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }

        private string StringifyType(ToHeadServerMessageType type)
        {
            switch (type)
            {
                case ToHeadServerMessageType.ReqRegister:
                    return "REQ MY REGISTER";
                case ToHeadServerMessageType.ReqDetach:
                    return "REQ MY DETACH";
                case ToHeadServerMessageType.ReqStatusUpdate:
                    return "REQ STATUS UPD";
                case ToHeadServerMessageType.UseMyData:
                    return "REQ USE MY DATA";
                case ToHeadServerMessageType.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }
    }
}
