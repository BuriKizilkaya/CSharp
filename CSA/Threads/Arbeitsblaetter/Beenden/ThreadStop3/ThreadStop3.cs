using System;
using System.Threading;

namespace ThreadStop3 {

    class ThreadStop3 {

        static void Main() {
            Thread t = new Thread(delegate() {
                try {
                    Console.WriteLine("Thread starts.");
                    while (true) ;
                }
                catch (ThreadAbortException) {
                    Console.WriteLine("ThreadAbortException.");
                    for (int i = 0; i < 100000000; i++) ;
                }
                finally {
                    Console.WriteLine("Thread ends.");
                }
            });
            Console.WriteLine("1. " + t.ThreadState);
            t.Start();
            Thread.Sleep(1000);
            Console.WriteLine("2. " + t.ThreadState);
            t.Abort();
            Console.WriteLine("3. " + t.ThreadState);
            t.Join();
            Console.WriteLine("4. " + t.ThreadState);
        }
    }
}
