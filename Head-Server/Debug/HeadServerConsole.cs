using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonLibrary.Model.ServerSide;

namespace HeadServer.Debug
{

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

        private string StringifyType(FromGameServerMessageType type)
        {
            switch (type)
            {
                case FromGameServerMessageType.ReqDetach:
                    return "REQUEST REGISTER";
                case FromGameServerMessageType.ReqRegister:
                    return "REQUEST DETACH";
                case FromGameServerMessageType.ReqStatusUpdate:
                    return "REQUEST STATUS CHANGE";
                case FromGameServerMessageType.UseMyData:
                    return "USE MY CONFIG";
                case FromGameServerMessageType.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }

        private string StringifyType(ToGameServerMessageType type)
        {
            switch (type)
            {
                case ToGameServerMessageType.AckDetach:
                    return "PERMIT DETACH";
                case ToGameServerMessageType.AckRegister:
                    return "PERMIT REGISTER";
                case ToGameServerMessageType.AckStatusUpdate:
                    return "PERMIT STATUS UPDATE";
                case ToGameServerMessageType.AckMyData:
                    return "APPLIED YOUR CONFIG";
                case ToGameServerMessageType.AckStatusData:
                    return "APPLIED YOUR STATUS";
                case ToGameServerMessageType.DenyRegister:
                    return "DENY REGISTER";
                case ToGameServerMessageType.DenyStatusUpdate:
                    return "DENY STATUS UPDATE";
                case ToGameServerMessageType.DenyMyData:
                    return "DENY YOUR CONFIG";
                case ToGameServerMessageType.DenyStatusData:
                    return "DENY YOUR STATUS";
                case ToGameServerMessageType.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }
    }
}
