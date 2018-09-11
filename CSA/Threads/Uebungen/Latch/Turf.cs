using System.Threading;
using System;

namespace Latch {

    class Turf {

        static void Main() {
            ISynch startBox = new Latch();
            for (int i = 1; i <= 5; i++) {
                new Thread(new RaceHorse(i, startBox).Run).Start();
            }
            Thread.Sleep(100);
            System.Console.WriteLine("Start...");
            startBox.Release();
            Console.ReadKey();
        }
    }
}
