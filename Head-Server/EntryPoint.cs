using HeadServer.Debug;
using System.Net;

namespace HeadServer
{
    /// <summary>
    /// Main entry point of Head server project
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            // Create head
            HeadServer head = new HeadServer(HeadTcpEndPoint);
            head.Initialize();
            HeadServerDebugManager debug_console = new HeadServerDebugManager(head, head.AuthServer);
            head.Start();
        }

        static EntryPoint()
        {
            HeadTcpEndPoint = new IPEndPoint(IPAddress.Loopback, 42077);
        }
        public static IPEndPoint HeadTcpEndPoint;
    }
}


/*  Debug 
     head.Start();
            if (head.AuthServer.TrySignUp(IPAddress.Loopback, new UserEntry("123", CommonLibrary.Implementation.Crypto.ShaEncryptor.Encrypt("123"))) == CommonLibrary.Model.ServerSide.SignupError.AllOk)
                Console.WriteLine("Signup OK");
            if (head.AuthServer.TrySignUp(IPAddress.Loopback, new UserEntry("laralex", CommonLibrary.Implementation.Crypto.ShaEncryptor.Encrypt("admin228"))) == CommonLibrary.Model.ServerSide.SignupError.AllOk)
                Console.WriteLine("Signup OK");
            if (head.AuthServer.TryLogIn(new UserEntry("garb2", new byte[] { 0xff, 0xfe })))
                Console.WriteLine("Login OK");
            else
                Console.WriteLine("Login Fail");
            var serv = new DiceGameServerEntry();
            serv.Name = "Alex test";
            serv.DiceNumber = 7;
            serv.IsActive = true;
            serv.IsJokerAllowed = true;
            serv.MaxPlayers = 10;
            serv.ScoreGoal = 9999;
            serv.Socket = new IPEndPoint(new IPAddress(1230981241), 60000);
            serv.TurnTimeSec = 59;
            serv.CreatorName = "Holy cow";
            if (head.DbServer.InsertDiceGameServer(serv))
                Console.WriteLine("Server OK");

            serv.Name = "DDOS server";
            serv.MaxPlayers = 30;
            serv.Socket = new IPEndPoint(new IPAddress(1330981241), 60000);
            if (head.DbServer.InsertDiceGameServer(serv))
                Console.WriteLine("Server OK");
            //if (head.DbServer.SetServerIsActive(1, false))
            //Console.WriteLine("Server inactive OK");
            serv.Name = "LOL server";
            serv.MaxPlayers = 100;
            serv.Socket = new IPEndPoint(new IPAddress(430981241), 60000);
            if (head.DbServer.InsertDiceGameServer(serv))
                Console.WriteLine("Server OK");
            //var list = head.DbServer.SelectActiveGameServers();

            //Console.ReadLine();
            //head.Dispose();

            //debug_console.EndOfProcessMessage();
     */
