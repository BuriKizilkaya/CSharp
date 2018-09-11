using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Latch {

    class Turf {

        static void Main() {
            ISynch starterBox = new Latch();
            for (int i = 1; i < 6; i++)
                new Thread(new RaceHorse(i, starterBox).Run).Start();
            Thread.Sleep(500);
            Console.WriteLine("Start!");
            starterBox.Release();
        }
    }
}
