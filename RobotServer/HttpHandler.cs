using System.Linq;
using System.Net;

namespace RobotServer
{
    public class HttpHandler
    {
        private HttpListenerContext _context;

        public HttpHandler(HttpListenerContext context)
        {
            _context = context;
        }

        public void HandleRequest()
        {
            HttpListenerResponse response = _context.Response;

            string responseString = "";
            string html = "";
            if(InternalStorage.Commands.Count == 0)
            {
                responseString = HtmlConst.HtmlEmptyContainer;
                html = responseString.Replace("$$Data", "Keine Daten gefunden.");
            }
            else
            {
                responseString = HtmlConst.HtmlDataContainer;
                var data = InternalStorage.Commands.Where(o => o.Action.ToString() != "Start").ToArray();
                html = responseString.Replace("$$Data", string.Join("<br/> &emsp; ", data.Select(o => o.ToString()).ToArray()));
            }

            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(html);
            response.ContentLength64 = buffer.Length;
            using(System.IO.Stream output = response.OutputStream)
            {
                output.Write(buffer, 0, buffer.Length);
                output.Close();
            }
        }
    }
}
