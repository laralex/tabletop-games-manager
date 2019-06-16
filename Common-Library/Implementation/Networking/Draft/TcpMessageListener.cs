using CommonLibrary.Model.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace CommonLibrary.Implementation.Networking.Tcp
{
    public sealed class IncommingMessageEventArgs<E> : EventArgs
    {
        public E Message { get; internal set; }

        public IPEndPoint Sender { get; internal set; }
    }

    public sealed class OutcommingMessageEventArgs<E> : EventArgs
    {
        public E Message { get; internal set; }
        
    }
    public class TcpMessageListener<E> : IDisposable
    {
        public event EventHandler<IncommingMessageEventArgs<E>> IncomingMessage;

        public TcpMessageListener(IPEndPoint remote)
        {
            _messenger = TcpNetworkFactory.MakeTcpMessanger<E>(remote.Address, remote.Port); 
        }

        public TcpMessageListener(INetworkMessenger<E> messenger)
        {
            _messenger = messenger;
        }
        private void ThreadProc()
        {
            while (!_exit)
            {
                try
                {
                    //E massage = reader.Read();
                    var args = new IncommingMessageEventArgs<E>
                    {
                        Message = _messenger.Receive(),
                        Sender = _messenger.RemoteEndPoint
                    };
                    IncomingMessage?.Invoke(this, args);
                }
                catch (Exception e)
                {
                    string message = e.Message;
                    string caption = "!> Error in TCP connection thread";
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
            _exit = true;
            _messenger.Dispose();
        }

        private bool _exit;

        private INetworkMessenger<E> _messenger;

    }
}
