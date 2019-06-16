
namespace CommonLibrary.Model.Networking
{
    /// <summary>
    /// Entity is able to send and receive some class instance by network
    /// </summary>
    /// <typeparam name="E"></typeparam>
    public interface INetworkMessenger<E> : INetworkReceiver<E>, INetworkSender<E>
    {

    }
}
