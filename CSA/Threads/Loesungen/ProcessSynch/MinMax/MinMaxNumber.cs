using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace MinMax {

    class MinMaxNumber {

        static void Main() {
            String semaId = "hslu.generator";
            Semaphore sema;
            try {
                sema = Semaphore.OpenExisting(semaId);
            }
            catch (WaitHandleCannotBeOpenedException) {
                sema = new Semaphore(0, 2, semaId);
            }
            int min = 0;
            int max = 0;
            Console.WriteLine("MinMax");
            try {
                sema.WaitOne();
                using (StreamReader sr = new StreamReader("daten.txt")) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        int num = Int32.Parse(line);
                        min = min > num ? num : min;
                        max = max < num ? num : max;
                        Console.Write(".");
                    }
                }
            }
            finally {
                sema.Release();
            }
            Console.WriteLine();
            Console.WriteLine("Min := " + min);
            Console.WriteLine("Max := " + max);
            Console.ReadLine();
        }
    }
}
