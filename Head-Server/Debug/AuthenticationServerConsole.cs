using System;
using CommonLibrary.Implementation.Common;
using CommonLibrary.Model.Common;
using CommonLibrary.Model.ServerSide;

namespace HeadServer.Debug
{

    /// <summary>
    /// Wrapper of debugging console
    /// It listens to events on authentication server and prints log in console
    /// </summary>
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
            Console.WriteLine("\tUser --> Auth : " + StringifyType(args.MessageType) + " : " + args.User.LoginName);
        }

        public void UserMessage(object sender, MessageToUserEventArgs args)
        {
            Console.WriteLine("\tUser <-- Auth : " + StringifyType(args.MessageType) + " : " + args.User.LoginName);
        }


        public void TerminationMessage(object sender, EventArgs args)
        {
            Console.WriteLine("\tAuth server: TERMINATE");
        }

        private string StringifyType(ClientToHeadServerMessage type)
        {
            switch (type)
            {
                case ClientToHeadServerMessage.ReqLogIn:
                    return "REQUEST LOG IN";
                case ClientToHeadServerMessage.ReqLogOut:
                    return "REQUEST LOG OUT";
                case ClientToHeadServerMessage.ReqSignUp:
                    return "REQUEST SIGN UP";
                case ClientToHeadServerMessage.ReqServersList:
                    return "REQUEST SERVERS LIST";
                case ClientToHeadServerMessage.UseMyData:
                    return "USE MY ACCOUNT DATA";
                case ClientToHeadServerMessage.Dummy:
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

        private string StringifyType(HeadServerToClientMessage type)
        {
            switch (type)
            {
                case HeadServerToClientMessage.AckLogIn:
                    return "PERMIT DETACH";
                case HeadServerToClientMessage.AckLogOut:
                    return "PERMIT REGISTER";
                case HeadServerToClientMessage.AckSignUp:
                    return "PERMIT STATUS UPDATE";
                case HeadServerToClientMessage.AckMyData:
                    return "APPLIED YOUR CONFIG";
                case HeadServerToClientMessage.DenyLogIn:
                    return "APPLIED YOUR STATUS";
                case HeadServerToClientMessage.DenyServerList:
                    return "DENY REGISTER";
                case HeadServerToClientMessage.DenySignUp:
                    return "DENY STATUS UPDATE";
                case HeadServerToClientMessage.UseServerList:
                    return "TAKE THIS SERVER LIST";
                case HeadServerToClientMessage.Dummy:
                    return "<DEBUG MSG>";
            }
            return null;
        }
    }
}
