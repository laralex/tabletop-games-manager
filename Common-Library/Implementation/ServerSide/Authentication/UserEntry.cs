using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Implementation.ServerSide.Authentication
{
    public class UserEntry
    {
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }

        public UserEntry(string name, byte[] passhash)
        {
            Name = name;
            PasswordHash = passhash;
        }
    }
}
