using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeadServer
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            // Create head
            HeadServer head = new HeadServer();
            head.Initialize();
            head.Start();
            head.Dispose();
        }
    }
}
