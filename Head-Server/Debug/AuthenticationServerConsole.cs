using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HeadServer.AuthenticationServer;
using CommonLibrary.Model.ServerSide;

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

        private string StringifyType(FromUserMessageType type)
        {
            switch (type)
            {
                case FromUserMessageType.ReqLogIn:
                    return "REQUEST LOG IN";
                case FromUserMessageType.ReqLogOut:
                    return "REQUEST LOG OUT";
                case FromUserMessageType.ReqSignUp:
                    return "REQUEST SIGN UP";
                case FromUserMessageType.ReqServersList:
                    return "REQUEST SERVERS LIST";
                case FromUserMessageType.UseMyData:
                    return "USE MY ACCOUNT DATA";
                case FromUserMessageType.Dummy:
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

        private string StringifyType(ToUserMessageType type)
        {
            switch (type)
            {
                case ToUserMessageType.AckLogIn:
                    return "PERMIT DETACH";
                case ToUserMessageType.AckLogOut:
                    return "PERMIT REGISTER";
                case ToUserMessageType.AckSignUp:
                    return "PERMIT STATUS UPDATE";
                case ToUserMessageType.AckMyData:
                    return "APPLIED YOUR CONFIG";
                case ToUserMessageType.DenyLogIn:
                    return "APPLIED YOUR STATUS";
                case ToUserMessageType.DenyServerList:
                    return "DENY REGISTER";
                case ToUserMessageType.DenySignUp:
                    return "DENY STATUS UPDATE";
                case ToUserMessageType.UseServerList:
                    return "TAKE THIS SERVER LIST";
                case ToUserMessageType.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }
    }
}
