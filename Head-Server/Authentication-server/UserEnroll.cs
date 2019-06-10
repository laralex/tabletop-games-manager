using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadServer.AuthenticationServer
{
    public class UserEntry
    {
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
