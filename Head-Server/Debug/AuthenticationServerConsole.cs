using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HeadServer.AuthenticationServer;
//using CommonLibrary.Model.ServerSide;
using CommonLibrary.Model.Common;
using CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer;
//using CommonLibrary.Model.ServerSide.HeadServerAndGameServer;
using ToHeadServerMessageType = CommonLibrary.Model.ServerSide.ApplicationClientAndHeadServer.ToHeadServerMessageType;

namespace HeadServer.Debug
{


    internal class AuthenticationServerConsole
    {
        public AuthenticationServerConsole(AuthenticationServer.AuthenticationServer server)
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
        }

        public void InitMessage(object sender, EventArgs args)
        {
            Console.WriteLine("\tAuth server: INIT");
        }

        public void NetworkThreadMessage(object sender, ThreadStateEventArgs args)
        {
            Console.WriteLine("\tAuth server: NETWORK THREAD " + StringifyType(args.State));
        }

        public void UserMessage(object sender, MessageFromUserEventArgs args)
        {
            Console.WriteLine("\tUser --> Auth : " + StringifyType(args.MessageType) + " : " + args.User.Name);
        }

        public void UserMessage(object sender, MessageToUserEventArgs args)
        {
            Console.WriteLine("\tUser <-- Auth : " + StringifyType(args.MessageType) + " : " + args.User.Name);
        }


        public void TerminationMessage(object sender, EventArgs args)
        {
            Console.WriteLine("\tAuth server: TERMINATE");
        }

        private string StringifyType(ToHeadServerMessageType type)
        {
            switch (type)
            {
                case ToHeadServerMessageType.ReqLogIn:
                    return "REQUEST LOG IN";
                case ToHeadServerMessageType.ReqLogOut:
                    return "REQUEST LOG OUT";
                case ToHeadServerMessageType.ReqSignUp:
                    return "REQUEST SIGN UP";
                case ToHeadServerMessageType.ReqServersList:
                    return "REQUEST SERVERS LIST";
                case ToHeadServerMessageType.UseMyData:
                    return "USE MY ACCOUNT DATA";
                case ToHeadServerMessageType.Dummy:
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
                case ToApplicationClientMessageType.AckLogIn:
                    return "PERMIT DETACH";
                case ToApplicationClientMessageType.AckLogOut:
                    return "PERMIT REGISTER";
                case ToApplicationClientMessageType.AckSignUp:
                    return "PERMIT STATUS UPDATE";
                case ToApplicationClientMessageType.AckMyData:
                    return "APPLIED YOUR CONFIG";
                case ToApplicationClientMessageType.DenyLogIn:
                    return "APPLIED YOUR STATUS";
                case ToApplicationClientMessageType.DenyServerList:
                    return "DENY REGISTER";
                case ToApplicationClientMessageType.DenySignUp:
                    return "DENY STATUS UPDATE";
                case ToApplicationClientMessageType.UseServerList:
                    return "TAKE THIS SERVER LIST";
                case ToApplicationClientMessageType.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }
    }
}
