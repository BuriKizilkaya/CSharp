using System;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace IterativerServer {
    public class IterativerServer {
        public static void Main() {
            IPAddress ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener listen = new TcpListener(ipAddress, 7070);
            listen.Start();
            while (true) {
                Console.WriteLine("Warte auf Verbindung auf Port " +
                    listen.LocalEndpoint + "...");
                TcpClient client = listen.AcceptTcpClient();
                Console.WriteLine("Verbindung zu " +
                    client.Client.RemoteEndPoint);
                StreamWriter sw = new StreamWriter(client.GetStream());
                sw.WriteLine(Environment.MachineName);
                sw.WriteLine(Environment.OSVersion);
                sw.Flush();
                client.Close();
            }
        }
    }
}
