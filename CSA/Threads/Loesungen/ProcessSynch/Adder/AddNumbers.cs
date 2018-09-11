
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace Adder {

    class AddNumbers {

        static void Main() {
            String semaId = "hslu.generator";
            Semaphore sema;
            try {
                sema = Semaphore.OpenExisting(semaId);
            }
            catch (WaitHandleCannotBeOpenedException) {
                sema = new Semaphore(0, 2, semaId);
            }
            int summe = 0;
            Console.WriteLine("Addierer");
            try {
                sema.WaitOne();
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
