using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LostSignals {

    class Operator {

        public const int MAXCOUNT = 4;
        private int counter = 0;
        private ISynch signal;
        private Random rnd;

        public Operator(ISynch signal) {
            this.signal = signal;
            rnd = new Random();
        }

        private void Init() {
            lock (this) {
                counter = MAXCOUNT;
                Console.WriteLine("Jetzt wurden " + counter + " Operationen vorbereitet...");
            }
        }

        public int Operation() {
            return rnd.Next(1000);
        }

        public void Done(String id) {
            lock (this) {
                counter++;
                Console.WriteLine(counter + ". Operation wurde durch " + id + " beendet.");
            }
        }

        public void Do() {
            while (true) {
                Init();
                do {
                    signal.Release();
                }
                while (!IsCounterNull());
                while (!IsCounterMax()) {
                    Thread.Sleep(10);
                }
            }
        }

        private bool IsCounterMax() {
            lock (this) {
                return counter == MAXCOUNT;
            }
        }

        private bool IsCounterNull() {
            lock (this) {
                counter--;
                return counter == 0;
            }
        }
    }
}
