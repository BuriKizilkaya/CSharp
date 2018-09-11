using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Latch {

    class RaceHorse {

        private static Random rnd = new Random();
        private ISynch startSignal;
        private int nr;

        public RaceHorse(int nr, ISynch startSignal) {
            this.nr = nr;
            this.startSignal = startSignal;
        }

        public void Run() {
            Console.WriteLine(nr.ToString() + " geht in Box.");
            startSignal.Acquire();
            Console.WriteLine(nr.ToString() + " verlässt Box.");
            Thread.Sleep(rnd.Next(3000));
            System.Console.WriteLine("Rennpferd " + nr + " ist im Ziel.");
        }
    }
}
