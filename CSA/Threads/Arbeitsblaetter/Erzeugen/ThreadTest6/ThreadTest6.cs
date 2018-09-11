using System;
using System.Threading;

namespace ThreadTest6 {

    class ThreadTest6 {

        static void Main() {
            Thread t = new Thread(Go);
            t.Start(true);
            Go(false);
        }
        static void Go(object upperCase) {
            if (upperCase.GetType() == typeof(bool)) {
                bool upper = (bool)upperCase;
                Console.WriteLine(upper ? "HELLO!" : "hello!");
            }
        }
    }
}
