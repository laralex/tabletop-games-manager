using System;

namespace HeadServer.Debug
{   /// <summary>
    /// Manages debugging console facilities (consoles for Head server and 
    /// Authentication server)
    /// </summary>
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
