using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NebenlaeufigerServer {
    public class EchoServer {
        public static void Main() {
            IPAddress ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener listen = new TcpListener(ipAddress, 7);
            listen.Start();
            while (true) {
                Console.WriteLine("Warte auf Verbindung auf Port " +
                    listen.LocalEndpoint + "...");
                TcpClient client = listen.AcceptTcpClient();
                Console.WriteLine("Echo Handler für " +
                    client.Client.RemoteEndPoint +
                    " erzeugen und starten");
                EchoHandler handler = new EchoHandler(client);
                new Thread(handler.DoEcho).Start();
            }
        }
    }
}
