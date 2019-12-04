using System;
using System.Linq;
using System.Net;
using System.Threading;

namespace RobotServer
{
    public class HttpServer
    {
        private HttpListener _listener;
        public event EventHandler HttpLog;

        public HttpServer(int port)
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://localhost:" + port + "/"); 
        }

        public void Start()
        {
            _listener.Start();
            HttpLog?.Invoke("HTTP Server Startet" + Environment.NewLine, null);
            while (true)
            {

                HttpListenerContext context = _listener.GetContext();
                if (context.Request.Url.Segments.Count() > 1 && context.Request.Url.Segments[1] == "favicon.ico") return; //workaround for second call 

                HttpLog?.Invoke("HTTP Server Connected" + Environment.NewLine, null);
                HttpHandler handler = new HttpHandler(context);
                new Thread(handler.HandleRequest).Start();
            }
        }
    }
}
