using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HeadServer.Debug;
using System.Net;
using CommonLibrary.Implementation.ServerSide.Authentication;
using CommonLibrary.Implementation.ServerSide;

namespace HeadServer
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            // Create head
            HeadServer head = new HeadServer(new IPEndPoint(IPAddress.Loopback, 42077));
            head.Initialize();
            HeadServerDebugManager debug_console = new HeadServerDebugManager(head, head.AuthServer);
            head.Start();
            System.Threading.Thread.Sleep(1000);
            if (head.AuthServer.TrySignUp(IPAddress.Loopback, new UserEntry("garb2", new byte[] { 0xff, 0xfe })))
                Console.WriteLine("Signup OK");
            if (head.AuthServer.TrySignUp(IPAddress.Loopback, new UserEntry("garb3", new byte[] { 0xff, 0xfd })))
                Console.WriteLine("Signup OK");
            if (head.AuthServer.TryLogIn(new UserEntry("garb2", new byte[] { 0xff, 0xfe })))
                Console.WriteLine("Login OK");

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
            if (head.DbServer.InsertDiceGameServer(serv))
                Console.WriteLine("Server OK");
            if (head.DbServer.SetServerIsActive(1, false))
                Console.WriteLine("Server inactive OK");
            if (head.DbServer.InsertDiceGameServer(serv))
                Console.WriteLine("Server OK");
            var list = head.DbServer.SelectActiveGameServers();

            Console.ReadLine();
            head.Dispose();

            debug_console.EndOfProcessMessage();
        }
    }
}
