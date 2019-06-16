using CommonLibrary.Model.Networking;
using System;
using System.Net;
using System.Threading;

namespace CommonLibrary.Implementation.Networking.Udp
{
    public sealed class IncommingMessageEventArgs<E> : EventArgs
    {
        public E Message { get; internal set; }

        public IPEndPoint Sender { get; internal set; }
    }

    /// <summary>
    /// UDP client, listening local port in separate thread
    /// </summary>
    /// <typeparam name="E"></typeparam>
    public class UdpMessageListener<E> : IDisposable
    {
        private bool exit;

        private INetworkReceiver<E> reader;

        public event EventHandler<IncommingMessageEventArgs<E>> IncomingMessage;

        public UdpMessageListener(int port)
        {
            reader = UdpNetworkFactory.MakeUdpReceiver<E>(port);
        }
        private void ThreadProc()
        {
            while (!exit)
            {
                try
                {
                    var args = new IncommingMessageEventArgs<E>
                    {
                        Message = reader.Receive(),
                        Sender = reader.RemoteEndPoint
                    };
                    IncomingMessage?.Invoke(this, args);
                }
                catch (Exception e)
                {
                    string message = e.Message;
                    string caption = "Error Detected in Input";
                    Console.WriteLine(caption + " : " + e.Message);
                }
            }
        }

        public void Start()
        {
            Thread thread = new Thread(ThreadProc) { IsBackground = true };
            thread.Start();
        }

        public void Dispose()
        {
            exit = true;
            reader.Dispose();

        }
    }
}
