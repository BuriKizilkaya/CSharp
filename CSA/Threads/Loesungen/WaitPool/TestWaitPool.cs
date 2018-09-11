using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WaitPool {

    class TestWaitPool {

        static void Main() {
            Object synch = new Object();
            MyThread myThread = new MyThread(synch);
            new Thread(myThread.Run).Start();
            Thread.Sleep(1000);
            lock (synch) {
                Monitor.Pulse(synch);
            }
        }
    }
}
