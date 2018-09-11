using System;
using System.Threading;

namespace ThreadTest5 {

    class ThreadTest5 {

        static void Main() {
            Thread t = new Thread(new ParameterizedThreadStart(Go));
            t.Start(true);
            Go(false);
        }
        static void Go(object upperCase) {
            bool upper = (bool)upperCase;
            Console.WriteLine(upper ? "HELLO!" : "hello!");
        }
    }
}
