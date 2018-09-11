using System;
using System.Threading;

namespace LostSignals {

    class AWait : ISynch {
        //private Object locker = new Object();
        private Semaphore sema = null;

        public AWait(int n) {
            sema = new Semaphore(0,n);
        }
        public void Acquire() {
            sema.WaitOne();
            //lock(locker) {
            //    Monitor.Wait(locker);
            //}
        }
        public void Release() {
            sema.Release();
            //lock(locker) {
            //    Monitor.Pulse(locker);  
            //}
        }
    }
}
