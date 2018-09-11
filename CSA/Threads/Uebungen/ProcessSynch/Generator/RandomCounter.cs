using System;
using System.IO;
using System.Threading;

namespace Generator {

    class RandomCounter {

        static void Main() {
            Random rnd = new Random();
            Semaphore sema = new Semaphore(0, 2, "hslu process synch");
            Console.WriteLine("Generator");
            try {
                using (StreamWriter sw = new StreamWriter("daten.txt")) {
                    int n = rnd.Next(5000)+5000;
                    for (int i = 0; i < n; i++) {
                        sw.WriteLine(rnd.Next(1000));
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
