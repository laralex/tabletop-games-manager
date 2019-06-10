using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

namespace CommonLibrary.Implementation.ServerSide
{
    public class GameServerEnroll
    {
        public string Name { get; set; }
        public string CreatorName { get; set; }
        public bool IsActive { get; set; }
        public IPEndPoint Socket { get; set; }
    }
}
