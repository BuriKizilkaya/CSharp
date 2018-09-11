using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LostSignals {

    class AWait : ISynch {

        private Semaphore sema = null;

        public AWait(int n) {
            sema = new Semaphore(0, n);
        }

        public void Acquire() {
            sema.WaitOne();
        }

        public void Release() {
            sema.Release();
        }
    }
}
