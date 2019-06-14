using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.Common
{
    public class ThreadStateEventArgs : EventArgs
    {
        public ThreadStateType State { get; }
        public ThreadStateEventArgs(ThreadStateType state)
        {
            State = state;
        }
    }
}
