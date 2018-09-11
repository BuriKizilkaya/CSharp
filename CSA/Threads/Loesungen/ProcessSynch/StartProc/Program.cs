using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace StartProc {

    class Program {

        static void Main() {
            if (File.Exists("daten.txt")) {
                File.Delete("daten.txt");
            }
            Console.WriteLine("<Enter> zum Start drücken...");
            Console.ReadLine();
            Process.Start("MinMax.exe");
            Process.Start("Adder.exe");
            Process.Start("Generator.exe");
        }
    }
}
