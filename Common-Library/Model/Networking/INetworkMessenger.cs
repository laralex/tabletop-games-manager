using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLibrary.Model.Networking
{
    public interface INetworkMessenger<E> : INetworkReceiver<E>, INetworkSender<E>
    {

    }
}
