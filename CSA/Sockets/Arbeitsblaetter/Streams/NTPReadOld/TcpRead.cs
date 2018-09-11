using System;
using System.Net.Sockets;
using System.IO;

namespace TcpRead {
    class TcpRead {
        public static void Main() {
            try {
                //Location: Physikalisch-Technische Bundesanstalt (PTB), Braunschweig, Germany
                TcpClient client = new TcpClient("192.53.103.103", 13); 
                StreamReader inStream = new StreamReader(client.GetStream());
                Console.WriteLine(inStream.ReadLine());
                client.Close();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
