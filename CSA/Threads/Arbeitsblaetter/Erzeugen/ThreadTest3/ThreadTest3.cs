using System;
using System.Threading;

namespace ThreadTest3 {

    class ThreadTest3 {

        private bool done;

        static void Main() {
            ThreadTest3 tt = new ThreadTest3();
            new Thread(tt.Go).Start();
            tt.Go();
        }
        void Go() {
            if (!done) {
                Thread.Sleep(0);
                done = true;
                Console.WriteLine("Done");
            }
        }
    }
}
