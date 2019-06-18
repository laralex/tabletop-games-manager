using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.ServerSide
{
    [Serializable]
    public class SubsystemIdentifier
    {

        public string Identifier { get => _identifier; }
        
        protected string _identifier;
    }
}
