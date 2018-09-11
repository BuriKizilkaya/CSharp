using System;
using System.Threading;

namespace WaitAndPulse {

    class WaitAndPulse {

        private static Object synch = new Object();

        static void Main() {
            new Thread(Waiter).Start();
            Thread.Sleep(1000);
            lock (synch) {
                Monitor.Pulse(synch);
            }
        }
        static void Waiter() {
            lock (synch) {
                Console.WriteLine("Waiting...");
                if (Monitor.Wait(synch, 1000)) {
                    Console.WriteLine("Notified");
                }
                else {
                    Console.WriteLine("Timeout");
                }
            }
        }
    }
}
