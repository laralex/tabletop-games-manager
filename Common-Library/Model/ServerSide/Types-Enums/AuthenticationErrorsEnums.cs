namespace CommonLibrary.Model.ServerSide
{
    /// <summary>
    /// Error codes for login or signup try by client
    /// </summary>
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
