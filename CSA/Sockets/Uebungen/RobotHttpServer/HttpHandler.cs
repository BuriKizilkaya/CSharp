using System;
using System.Net.Sockets;
using System.IO;

namespace SimpleHttpServer {

    public class HttpHandler {

        private TcpClient client;

        public HttpHandler(TcpClient client) {
            this.client = client;
        }

        public void Do() {
            String filename = @"Temp\RobotHttpServer\daten.txt";
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            Console.WriteLine("Verbindung zu " +
                client.Client.RemoteEndPoint);
            String head = sr.ReadLine();
            Console.WriteLine(head);
            // Datei lesen

            // Datei im HTTP-Format senden

            //client.Close();
        }
    }
}
