using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.Application
{
    /// <summary>
    /// Minimal data about connected user
    /// </summary>
    public interface IUser
    {
        string Name { get; }
        string LoginName { get; }
        //public DateTime
    }
}
