using System;

namespace BlackHole {

    class BlackHole {

        private NotifyingQueue<String> queue = new NotifyingQueue<String>();

        public void put(String thing) {
            lock (queue) {
                //...kritscher Code
            }
            queue.enqueue(thing);
        }
        public String get() {
            lock (queue) {
                //...kritscher Code
            }
            return queue.dequeue();
        }
    }
}
