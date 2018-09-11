using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Test_Join
{
    class Program
    {
        List<Thread> workerThreads = new List<Thread>();
        List<int> results = new List<int>();

        public void run()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(() => {
                    Thread.Sleep(new Random().Next(1000, 5000));
                    lock (results)
                    {
                        results.Add(new Random().Next(1, 10));
                    }
                });
                workerThreads.Add(thread);
                Console.WriteLine("Thread gestartet..."); 
                thread.Start();
            }

            // Wait for all the threads to finish so that the results list is populated.
            // If a thread is already finished when Join is called, Join will return immediately. (immediately: sofort)
            foreach (Thread thread in workerThreads)
            {
                thread.Join();
            }

            Console.WriteLine("Sum of results: " + results.Sum());
        }

        static void Main(string[] args)
        {
            Program Test_Join = new Program();
            Test_Join.run();
        }
    }
}
