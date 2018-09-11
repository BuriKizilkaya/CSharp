using System;
using System.Threading;

namespace SimpleBlocking {

    class SimpleBlocking {

        static void Main() {
            long sum = 0;
            bool fertig = false;
            Thread t = new Thread(delegate () {
                for (int i = 0; i <= 1000000000; i++) {
                    sum += i;
                }
                fertig = true;
            });
            t.Start();
            // Version 1
            //while (!fertig) ;
            // Version 2
            //Thread.Sleep(5000);
            // Version 2b
            //while (!fertig) {
            //    Thread.Sleep(100);
            //}
            // Version 3
            t.Join();
            Console.WriteLine("Summe = " + sum);
        }
    }
}
