using CommonLibrary.Model.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CommonLibrary.Implementation.ServerSide.Authentication
{
    public struct UserSocket
    {
        public UserSocket(IUser user, IPEndPoint socket) : this()
        {
            User = user;
            Socket = socket;
        }

        public IUser User { get; set; }
        public IPEndPoint Socket { get; set; }
    }
}
