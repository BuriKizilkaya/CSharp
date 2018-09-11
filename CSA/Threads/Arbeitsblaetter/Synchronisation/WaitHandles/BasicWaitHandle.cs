using System;
using System.Threading;

namespace WaitHandles1 {

    class BasicWaitHandle {

        //private static EventWaitHandle wh = new AutoResetEvent(false);
        private static EventWaitHandle wh = new ManualResetEvent(false);

        static void Main() {
            //wh.Set();
            new Thread(Waiter).Start();
            new Thread(Waiter).Start();
            Thread.Sleep(1000);
            wh.Set();
            wh.Reset();
            new Thread(Waiter).Start();
        }
        static void Waiter() {
            Console.WriteLine("Waiting...");
            wh.WaitOne();
            Console.WriteLine("Notified");
        }
    }
}
