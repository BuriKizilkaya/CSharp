using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
namespace RobotHttpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# on Windows Embedded Systems");
            TcpListener listen = new TcpListener(8080);
            listen.Start();
            while (true)
            {
                Console.WriteLine("Warte auf Verbindung auf Port " + listen.LocalEndpoint + "...");
                TcpClient client = listen.AcceptTcpClient();
                Console.WriteLine("Verbindung zu " + client.Client.RemoteEndPoint);
                TextWriter tw = new StreamWriter(client.GetStream());
                tw.Write(DateTime.Now.ToString());
                tw.Flush();
                client.Close();
            }
        }
    }
}
