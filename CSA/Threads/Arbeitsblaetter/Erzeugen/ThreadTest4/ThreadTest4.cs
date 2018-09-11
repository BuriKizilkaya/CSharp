using System;
using System.Threading;

namespace ThreadTest4 {

    class ThreadTest4 {

        static void Main() {
            Thread t = new Thread(new ThreadStart(Go));
            t.Start();
            Go();
        }
        static void Go() {
            Console.WriteLine("hello!");
        }
    }
}
