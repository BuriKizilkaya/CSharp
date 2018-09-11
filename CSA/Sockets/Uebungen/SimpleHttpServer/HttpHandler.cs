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
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            Console.WriteLine("Verbindung zu " +
                client.Client.RemoteEndPoint);
            String head = sr.ReadLine();
            Console.WriteLine(head);
            if (head.Contains("GET")) {
                // Datei lesen
                String response = new StreamReader("daten.txt").ReadToEnd();
                // Datei im HTTP-Format senden
                sw.WriteLine("HTTP/1.0 200 OK");
                sw.WriteLine("Content-type: text/plain");
                sw.WriteLine("Content-lenght: "+response.Length);
                sw.WriteLine();
                sw.WriteLine(response);
                sw.Flush();
            }
            client.Close();
        }
    }
}
