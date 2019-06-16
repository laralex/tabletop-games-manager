using System;

using CommonLibrary.Model.ServerSide;
using CommonLibrary.Model.Common;
using CommonLibrary.Implementation.Common;

namespace HeadServer.Debug
{
    /// <summary>
    /// Wrapper of debugging console
    /// It listens to events on head server and prints log in console
    /// </summary>
    internal class HeadServerConsole
    {
        public HeadServerConsole(HeadServer server)
        {
            server.OnInitialization += InitMessage;
            server.OnThreadStateChange += NetworkThreadMessage;
            server.OnTermination += TerminationMessage;
            server.OnMessageFromGameServer += GameServerMessage;
            server.OnMessageToGameServer += GameServerMessage;
        }

        public void InitMessage(object sender, EventArgs args)
        {
            Console.WriteLine("Head server: INIT");
        }

        public void NetworkThreadMessage(object sender, ThreadStateEventArgs args)
        {
            Console.WriteLine("Head server: NETWORK THREAD " + StringifyType(args.State));
        }

        public void GameServerMessage(object sender, MessageFromGameServerEventArgs args)
        {
            Console.WriteLine("GameServer --> Head " + StringifyType(args.MessageType) + ": " + args.Server.Name);
        }

        public void GameServerMessage(object sender, MessageToGameServerEventArgs args)
        {
            Console.WriteLine("GameServer <-- Head " + StringifyType(args.MessageType) + ": " + args.Server.Name);
        }

        public void TerminationMessage(object sender, EventArgs args)
        {
            Console.WriteLine("Head server: TERMINATE");
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

        private string StringifyType(GameToHeadServerMessage type)
        {
            switch (type)
            {
                case GameToHeadServerMessage.ReqDetach:
                    return "REQUEST REGISTER";
                case GameToHeadServerMessage.ReqRegister:
                    return "REQUEST DETACH";
                case GameToHeadServerMessage.ReqStatusUpdate:
                    return "REQUEST STATUS CHANGE";
                case GameToHeadServerMessage.UseMyData:
                    return "USE MY CONFIG";
                case GameToHeadServerMessage.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }

        private string StringifyType(HeadToGameServerMessage type)
        {
            switch (type)
            {
                case HeadToGameServerMessage.AckDetach:
                    return "PERMIT DETACH";
                case HeadToGameServerMessage.AckRegister:
                    return "PERMIT REGISTER";
                case HeadToGameServerMessage.AckStatusUpdate:
                    return "PERMIT STATUS UPDATE";
                case HeadToGameServerMessage.AckMyData:
                    return "APPLIED YOUR CONFIG";
                case HeadToGameServerMessage.AckStatusData:
                    return "APPLIED YOUR STATUS";
                case HeadToGameServerMessage.DenyRegister:
                    return "DENY REGISTER";
                case HeadToGameServerMessage.DenyStatusUpdate:
                    return "DENY STATUS UPDATE";
                case HeadToGameServerMessage.DenyMyData:
                    return "DENY YOUR CONFIG";
                case HeadToGameServerMessage.DenyStatusData:
                    return "DENY YOUR STATUS";
                case HeadToGameServerMessage.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }
    }
}
