using System;
using System.Net.Sockets;
using System.IO;

namespace TcpRead {
    class TcpRead {
        public static void Main() {
            TcpClient client = new TcpClient("whois.nic.ch", 43); // whois von switch
            StreamWriter outStream = new StreamWriter(client.GetStream());
            StreamReader inStream = new StreamReader(client.GetStream());
            outStream.WriteLine("hslu.ch");
            outStream.Flush();
            String line;
            while ((line = inStream.ReadLine()) != null) {
                Console.WriteLine(line);
            }
            client.Close();
        }
    }
}
