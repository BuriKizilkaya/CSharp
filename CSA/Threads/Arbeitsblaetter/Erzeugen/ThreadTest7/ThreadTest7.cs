using System.Threading;

namespace ThreadTest7 {

    class ThreadTest7 {

        static void Main() {
            // Tasks erzeugen...
            AdditionTask work1 = new AdditionTask("A", 100000000);
            AdditionTask work2 = new AdditionTask("B", 100000);
            AdditionTask work3 = new AdditionTask("C", 100);
            // Threads erzeugen...
            Thread t1 = new Thread(new ThreadStart(work1.Add));
            Thread t2 = new Thread(new ThreadStart(work2.Add));
            Thread t3 = new Thread(new ThreadStart(work3.Add));
            // Threads starten...
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
