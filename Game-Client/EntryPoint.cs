
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

using GameClient.Application;

namespace GameClient
{
    internal static class EntryPoint
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            var auth = new AuthenticationBackend();
            System.Windows.Forms.Application.Run(auth.FrontEndForm);
        }

        static EntryPoint()
        {
            ClientTcpEndPoint = new IPEndPoint(IPAddress.Loopback, 42078);
            HeadTcpEndPoint = new IPEndPoint(IPAddress.Loopback, 42077);
        }
        public static TcpClient InitHeadTcpClient()
        {
            return HeadTcpClient = new TcpClient(ClientTcpEndPoint);
        }
        public static IPEndPoint ClientTcpEndPoint;
        public static TcpClient HeadTcpClient;
        public static IPEndPoint HeadTcpEndPoint;

    }
}

