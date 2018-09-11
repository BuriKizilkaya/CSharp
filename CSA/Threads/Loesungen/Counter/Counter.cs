using System.Threading;

namespace Counter {

    class Counter {

        private int count = 0;
        private object locker = new object();
        public int NextNumber() {
            lock (locker) {
                count++;
                Thread.Sleep(1);
                return count;
            }
        }
    }
}