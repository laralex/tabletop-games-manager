namespace CommonLibrary.Model.Common
{
    /// <summary>
    /// State of thread, managed by control thread
    /// </summary>
    public enum ThreadState
    {
        Dummy,
        Begin,
        Resume,
        Stop,
        End,
    }
}
