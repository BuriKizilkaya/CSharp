using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;

namespace Testat_FS18_Diehl
{
    class HttpServer
    {
        private TcpListener httpServer;

        public HttpServer()
        {
            httpServer = new TcpListener(IPAddress.Any, 8080);
        }

        public void StartServer()
        {
            httpServer.Start();
            while (true)
            {
                Console.WriteLine("Warte auf Verbindung auf Port " +
                    httpServer.LocalEndpoint + "...");
                TcpClient client = httpServer.AcceptTcpClient();
                Console.WriteLine("HttpHandler für " +
                    client.Client.RemoteEndPoint +
                    " erzeugen und starten");
                HttpHandler handler = new HttpHandler(client);
                new Thread(handler.Do).Start();
            }
        }
    }
}
