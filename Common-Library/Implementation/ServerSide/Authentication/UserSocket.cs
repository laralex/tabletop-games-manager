using CommonLibrary.Model.Application;
using System.Net;

namespace CommonLibrary.Implementation.ServerSide.Authentication
{
    /// <summary>
    /// Name of user + IP + port of sender client
    /// </summary>
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
