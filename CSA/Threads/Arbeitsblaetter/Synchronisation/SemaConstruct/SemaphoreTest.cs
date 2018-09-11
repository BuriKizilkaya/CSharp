using System;
using System.Threading;

namespace SemaConstruct {

    class SemaphoreTest {

        private static Semaphore s = new Semaphore(0, 3);  // Available=3; Capacity=3

        static void Main() {
            s.Release(4);
            for (int i = 0; i < 10; i++) {
                new Thread(Go).Start(i);
            }
        }
        static void Go(object number) {
            while (true) {
                Console.WriteLine(number.ToString() + ". Thread waits.");
                s.WaitOne();
                Console.WriteLine(number.ToString() + ". Thread is in critical section");
                Thread.Sleep(1000);   // Only 3 threads can get here at once
                s.Release();
                Console.WriteLine(number.ToString() + ". Thread leaves.");
            }
        }
    }
}
