using CommonLibrary.Model.Common;
using System;

namespace CommonLibrary.Implementation.Common
{
    /// <summary>
    /// Event args about thread's change of state
    /// </summary>
    public class ThreadStateEventArgs : EventArgs
    {
        public ThreadState State { get; }
        public ThreadStateEventArgs(ThreadState state)
        {
            State = state;
        }
    }
}
