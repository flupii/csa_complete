using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace RobotServer
{
    public class TcpServer
    {
        private TcpListener _listener;
        public event EventHandler TcpLog;

        public TcpServer(int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
        }

        public void Start()
        {
            _listener.Start();
            TcpLog?.Invoke("TCP Server Startet" + Environment.NewLine, null);
            while (true)
            {
                TcpClient client = _listener.AcceptTcpClient();
                TcpLog?.Invoke("TCP Server Connected" + Environment.NewLine, null);
                TcpHandler handler = new TcpHandler(client);
                new Thread(handler.HandleRequest).Start();
            }
        }
    }
}
