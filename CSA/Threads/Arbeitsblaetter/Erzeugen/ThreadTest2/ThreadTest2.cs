using System;
using System.Threading;

namespace ThreadTest2 {

    class ThreadTest2 {

        static void Main() {
            new Thread(Go).Start();
            Go();
        }
        static void Go() {
            for (int i = 0; i < 5; i++) {
                Console.Write('x');
            }
        }
    }
}
