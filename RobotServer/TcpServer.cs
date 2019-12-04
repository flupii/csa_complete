using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RobotServer
{
    public class TcpServer
    {
        TcpListener listener;
        public event EventHandler TCPLog;

        public TcpServer(int port)
        {
            listener = new TcpListener(IPAddress.Any, port);
        }

        public void Start()
        {
            listener.Start();
            TCPLog?.Invoke("TCP Server Startet" + Environment.NewLine, null);
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                TCPLog?.Invoke("TCP Server Connected" + Environment.NewLine, null);
                TcpHandler handler = new TcpHandler(client);
                new Thread(handler.HandleRequest).Start();
            }
        }
    }
}
