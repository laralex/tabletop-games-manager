using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HeadServer.AuthenticationServer;

namespace HeadServer.Debug
{
    internal class HeadServerDebugManager
    {
        public HeadServerConsole HeadDebugConsole { get; }
        public AuthenticationServerConsole AuthDebugConsole { get; }

        public HeadServerDebugManager(HeadServer head_server, AuthenticationServer.AuthenticationServer auth_server)
        {
            HeadDebugConsole = new HeadServerConsole(head_server);
            AuthDebugConsole = new AuthenticationServerConsole(auth_server);
        }

        public void EndOfProcessMessage()
        {
            Console.WriteLine(" < PROCESS TERMINATION > ");
        }
    }
}
