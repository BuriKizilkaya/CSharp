using System;
using System.Threading;

namespace ThreadTest1 {

    class ThreadTest1 {

        static void Main() {
            Thread t = new Thread(WriteY);
            t.Start();
            while (true) Console.Write("x");
        }
        static void WriteY() {
            while (true) Console.Write("y");
        }
    }
}
