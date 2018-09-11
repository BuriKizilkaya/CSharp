using System;

namespace ThreadTest7 {

    class AdditionTask {

        private int n;
        private String id;

        public AdditionTask(String id, int n) {
            this.id = id;
            this.n = n;
        }
        public void Add() {
            long sum = 0;
            for (int i = 0; i <= n; i++) {
                sum += i;
            }
            Console.WriteLine(id + ": SUM" + n + " -> " + sum);
        }
    }
}
