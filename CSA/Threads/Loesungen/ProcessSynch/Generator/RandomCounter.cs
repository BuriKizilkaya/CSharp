using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace Generator {

    class RandomCounter {

        static void Main() {
            String semaId = "hslu.generator";
            Semaphore sema;
            try {
                sema = Semaphore.OpenExisting(semaId);
            }
            catch (WaitHandleCannotBeOpenedException) {
                sema = new Semaphore(0, 2, semaId);
            }
            Random rnd = new Random();
            Console.WriteLine("Generator");
            try {
                using (StreamWriter sw = new StreamWriter("daten.txt")) {
                    int n = 15000 + rnd.Next(5000);
                    for (int i = 0; i < n; i++) {
                        int value = -25000 + rnd.Next(50000);
                        sw.WriteLine(value);
                        Console.Write(".");
                    }
                }
            }
            finally {
                sema.Release(2);
            }
            Console.WriteLine();
            Console.WriteLine("fertig.");
            Console.ReadLine();
        }
    }
}
