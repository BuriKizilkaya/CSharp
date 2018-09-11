using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;

namespace HttpHandler
{
    public class HttpHandler
    {
        private TcpClient client;
        private String pfad;

        public HttpHandler(TcpClient client, string pfad)
        {
            this.client = client;
            this.pfad = pfad;
        }

        public void Do()
        {

            StreamReader srClient = new StreamReader(client.GetStream());
            StreamWriter swClient = new StreamWriter(client.GetStream());
            Console.WriteLine("Verbindung zu " +client.Client.RemoteEndPoint);
            String head = srClient.ReadLine();
            // Datei lesen
            // Datei im HTTP-Format senden
            StreamReader srFile = new StreamReader("PositionLog.txt");
            String filedata = srFile.ReadToEnd();

            if (head.Contains("GET"))
            {
                swClient.WriteLine("HTTP/1.1 200 OK");
                swClient.WriteLine("Content-type: text/plain");
                swClient.WriteLine("Content - length: " + filedata.Length);
                swClient.WriteLine();
                swClient.WriteLine(filedata);
                swClient.Flush();
                client.Close();
            }

        }
    }
}
