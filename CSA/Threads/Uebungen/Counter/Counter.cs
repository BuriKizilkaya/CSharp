using System.Threading;

namespace Counter {

    class Counter {

        private int count = 0;

        public int NextNumber() {
            lock(this) {
                count++;
                //Thread.Sleep(0);
                return count;
            }
        }
    }
}
