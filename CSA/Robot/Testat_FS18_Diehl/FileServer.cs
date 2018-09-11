using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Collections;

namespace Testat_FS18_Diehl
{
    class FileServer
    {
        private TcpListener listener;
        private TcpClient client;
        private ArrayList driveInstructions;
        private bool startInstruction;

        public FileServer()
        {
            listener = new TcpListener(IPAddress.Any, 8888);
            driveInstructions = new ArrayList();
            startInstruction = false;
        }

        public void StartServer()
        {
            listener.Start();
            Console.WriteLine("Warten auf Verbindung" +
                    listener.LocalEndpoint); 
            client = listener.AcceptTcpClient();
            Console.WriteLine("Verbindung war erfolgreich!");
            StreamReader reader = new StreamReader(client.GetStream());

            // start Server
            string readedLine;
            while ((readedLine = reader.ReadLine()) != null)
            {
                driveInstructions.Add(readedLine);
                Console.WriteLine(readedLine);
            }

            // check is the Start Instruction at least from File
            if(driveInstructions.Contains("Start"))
            {
                startInstruction = true;
                driveInstructions.Remove("Start");
            }
            else if (driveInstructions.Contains("start"))
            {
                startInstruction = true;
                driveInstructions.Remove("start");
            }

            // close Streams and Client
            reader.Close();
            client.Close();          
        }

        public ArrayList DriveInstructions
        {
            get
            {
                return driveInstructions;
            }
        }

        public bool StartInstruction
        {
            get
            {
                return startInstruction;
            }
        }

    }
}
