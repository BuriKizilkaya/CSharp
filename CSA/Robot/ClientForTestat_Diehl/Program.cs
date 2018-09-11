using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace ClientForTestat_Diehl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verbindung mit dem Server wird aufgebaut...");
            TcpClient client = new TcpClient("192.168.1.5", 8888);
            FileStream fileStream = new FileStream("fahrstrecken.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            StreamWriter writer = new StreamWriter(client.GetStream());
            Console.WriteLine("Verbindung mit dem Server war erfolgreich!");
            string readedLine;

            try
            {
                Console.WriteLine("Daten werden gesendet...");
                while ((readedLine = reader.ReadLine()) != null)
                {
                    writer.WriteLine(readedLine);
                    Console.WriteLine(readedLine);
                    writer.Flush();
                }
                Console.WriteLine("Daten fertig gesendet!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                reader.Close();
                writer.Close();
                fileStream.Close();
            }
            Console.ReadKey();
        }
    }
}
