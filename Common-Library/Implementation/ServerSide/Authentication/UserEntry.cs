using CommonLibrary.Model.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Implementation.ServerSide.Authentication
{
    /// <summary>
    /// Data of user - Safe to network send 
    /// </summary>
    [Serializable]
    public class UserEntry : IUser
    {
        public string LoginName { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Name { get; }

        public UserEntry(string name, byte[] passhash)
        {
            LoginName = name;
            Name = name;
            PasswordHash = passhash;
        }
    }
}
