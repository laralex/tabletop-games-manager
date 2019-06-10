using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadServer.Debug
{
    internal enum UserMessageType { LogIn, LogOut, SignUp }
    internal enum ThreadStateType { Begin, Resume, Stop, End }
    internal enum GameServerMessageType { Registered, Detached, GameStatusUpdate}
    internal class HeadServerConsole
    {
        public HeadServerConsole()
        {

        }

        public void InitMessage()
        {
            Console.WriteLine("Head server: INIT");
        }

        public void AuthenticationInitMessage()
        {
            Console.WriteLine("Authentication server: INIT");
        }

        public void NetworkThreadMessage(ThreadStateType type)
        {
            Console.WriteLine("Head server: NETWORK THREAD " + StringifyType(type));
        }

        public void AuthNetworkThreadMessage(ThreadStateType type)
        {
            Console.WriteLine("Authentication server: THREAD " + StringifyType(type));
        }

        public void UserMessage(DB.User user, UserMessageType type)
        {
            Console.WriteLine("User " + StringifyType(type) + ": " + user.Name);
        }

        public void GameServerMessage(DB.GameServer server, GameServerMessageType type)
        {
            Console.WriteLine("Game server " + StringifyType(type) + ": " + server.Name);
        }

        public void TerminationMessage()
        {
            Console.WriteLine("Head server: TERMINATE");
        }

        public void AuthenticationTerminationMessage()
        {
            Console.WriteLine("Authentication server: TERMINATE");
        }

        private string StringifyType(UserMessageType type)
        {
            switch (type)
            {
                case UserMessageType.LogIn:
                    return "LOG IN";
                case UserMessageType.LogOut:
                    return "LOG OUT";
                case UserMessageType.SignUp:
                    return "SIGN UP";
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
            }
            return null;
        }

        private string StringifyType(GameServerMessageType type)
        {
            switch (type)
            {
                case GameServerMessageType.Registered:
                    return "REGISTER";
                case GameServerMessageType.Detached:
                    return "DETACH";
                case GameServerMessageType.GameStatusUpdate:
                    return "STATUS CHANGE";
            }
            return null;
        }
    }
}
