using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

namespace CommonLibrary.Implementation.ServerSide
{
    [Serializable]
    public class GameServerEntry
    {
        public string Name { get; set; }
        public string CreatorName { get; set; }
        public bool IsActive { get; set; }
        public IPEndPoint Socket { get; set; }
        public int MaxPlayers { get; set; }
    }
}
