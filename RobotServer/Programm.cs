using System;
using System.Threading;

namespace RobotServer
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            TcpServer tcpServer = new TcpServer(7300);
            tcpServer.TcpLog += Server_TCPLog;
            new Thread(tcpServer.Start).Start();

            HttpServer httpServer = new HttpServer(8080);
            httpServer.HttpLog += HttpServer_HttpLog;
            new Thread(httpServer.Start).Start();
        }

        private static void HttpServer_HttpLog(object sender, EventArgs e)
        {
            Console.Write(sender);
        }

        private static void Server_TCPLog(object sender, EventArgs e)
        {
            Console.Write(sender);
        }
    }
}
