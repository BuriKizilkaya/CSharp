using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Latch {

    class Latch : ISynch {

        private EventWaitHandle signal = new ManualResetEvent(false);

        public void Acquire() {
            signal.WaitOne();
        }

        public void Release() {
            signal.Set();
        }
    }
}
