using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HeadServer.Debug;
using System.Net;

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
            System.Threading.Thread.Sleep(10000);
            head.Dispose();

            debug_console.EndOfProcessMessage();
        }
    }
}
