using System;
using System.Text;
using System.Net;
using System.IO;

namespace fake_gateway
{
    class Program
    {
        static void Main(string[] args)
        {    
            new Program().Run(
                args[0], 
                Int32.Parse(args[1]));
        }

        private Encoding ISOencoding = Encoding.GetEncoding("ISO-8859-1");

        private void Run(string ip, int port)
        {
            string url = string.Format("http://{0}:{1}/", ip, port);
            Console.WriteLine("Fake Gateway listening on {0}", url);
            using (var httpListener = new HttpListener())
            {
                httpListener.Prefixes.Add(url);
                httpListener.Start();
                HandleRequests(httpListener);
            }
        }

        private void HandleRequests(HttpListener httpListener)
        {
            while (true) // forever baby
            {
                var requestContext = httpListener.GetContext();                
                Log(requestContext.Request.InputStream);
                SendResponse(
                    "<?xml version=\"1.0\"?>\n" +
                    "<SESSION><LOGON>OK</LOGON>" +
                    "<MSGLST><!-- FAKE GATEWAY DOES NOT GIVE PROPER RESPONSE --></MSGLST>" +
                    "</SESSION>",
                    requestContext);
            }
        }

        private void Log(Stream stream)
        {
            using (var reader = new StreamReader(stream, ISOencoding))
                Console.WriteLine("Incoming request: {0}", reader.ReadToEnd());
        }

        private void SendResponse(string response, HttpListenerContext requestContext)
        {
            var outBytes = ISOencoding.GetBytes(response);
            requestContext.Response.ContentType = "text/xml";
            requestContext.Response.ContentLength64 = outBytes.Length;
            requestContext.Response.OutputStream.Write(outBytes, 0, outBytes.Length);
            requestContext.Response.StatusCode = 200;
            requestContext.Response.Close();
        }
    }
}
