using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.ServerSide
{
    public enum LoginError
    {
        AllOk,
        WrongEntry,
        HeadServerUnavailable
    }

    public enum SignupError
    {
        AllOk,
        UserExists,
        InvalidUsername,
        InvalidPassword,
        HeadServerUnavailable
    }
}
