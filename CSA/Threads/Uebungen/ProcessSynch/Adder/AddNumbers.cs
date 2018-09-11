using System;
using System.IO;
using System.Threading;

namespace Adder {

    class AddNumbers {

        static void Main() {
            int summe = 0;
            Semaphore sema = new Semaphore(0, 2, "hslu process synch");
            Console.WriteLine("Addierer");
            sema.WaitOne();
            try {
                using (StreamReader sr = new StreamReader("daten.txt")) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        summe += Int32.Parse(line);
                        Console.Write(".");
                    }
                }
            }
            finally {
                sema.Release();
            }
            Console.WriteLine();
            Console.WriteLine("Summe := " + summe);
            Console.ReadLine();
        }
    }
}
