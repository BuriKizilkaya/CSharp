using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WaitPool {

    class MyThread {

        private Object synch;

        public MyThread(Object synch) {
            this.synch = synch;
        }

        public void Run() {
            Console.WriteLine("warten...");
            lock (synch) {
                Monitor.Wait(synch);
            }
            Console.WriteLine("...aufgewacht");
        }
    }
}
