using CommonLibrary.Model.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace CommonLibrary.Implementation.Networking.Udp
{
    public sealed class IncommingMessageEventArgs<E> : EventArgs
    {
        public E Message { get; internal set; }

        public IPEndPoint Sender { get; internal set; }
    }
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
                    //E massage = reader.Read();
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
