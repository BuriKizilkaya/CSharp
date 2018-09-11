using System;
using System.Collections.Generic;
using System.Text;

namespace BlackHole {

    class BlackHole {

        private NotifyingQueue<String> queue = new NotifyingQueue<String>();

        public void put(String thing) {
            queue.enqueue(thing);
        }

        public String get() {
            return queue.dequeue();
        }
    }
}
