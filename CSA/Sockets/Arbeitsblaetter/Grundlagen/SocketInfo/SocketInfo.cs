using System;
using System.Net.Sockets;

namespace SocketInfo {

    public class SocketInfo {

        public static void Main(string[] args) {
            Console.WriteLine("Socket Information");
            for (int i = 0; i < args.Length; i++) {
                try {
                    TcpClient theClient = new TcpClient(args[i], 80);
                    Socket theSocket = theClient.Client;
                    Console.WriteLine(
                        "Der lokale Host (" +
                        theSocket.LocalEndPoint +
                        ") ist verbunden mit");
                    Console.WriteLine(
                        "dem entfernten Host " + args[i] + " (" +
                        theSocket.RemoteEndPoint + ")");
                    Console.WriteLine(
                        "über einen " + theSocket.ProtocolType + " Socket.");
                    theClient.Close();
                }
                catch (Exception e) {
                    Console.Error.WriteLine(e);
                }
            }
        }
    }
}
