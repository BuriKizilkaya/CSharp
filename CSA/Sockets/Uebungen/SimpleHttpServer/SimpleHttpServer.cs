using System;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;

namespace SimpleHttpServer {

    public class SimpleHttpServer {

        public static void Main() {
            IPAddress ipAddress = Dns.GetHostEntry(Environment.MachineName).AddressList[0];
            Console.WriteLine(ipAddress.ToString());
            TcpListener listen = new TcpListener(IPAddress.Any, 8080);
            listen.Start();
            while (true) {
                Console.WriteLine("Warte auf Verbindung auf Port " +
                    listen.LocalEndpoint + "...");
                TcpClient client = listen.AcceptTcpClient();
                Console.WriteLine("HttpHandler für " +
                    client.Client.RemoteEndPoint +
                    " erzeugen und starten");
                HttpHandler handler = new HttpHandler(client);
                new Thread(handler.Do).Start();
            }
        }
    }
}
