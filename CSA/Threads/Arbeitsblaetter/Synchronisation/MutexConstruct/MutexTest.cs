using System;
using System.Threading;

namespace MutexConstruct {

    class MutexTest {

        // Use a name unique to the application (eg include your company URL)
        private static Mutex mutex = new Mutex(false, "oreilly.com OneAtATimeDemo");

        static void Main() {
            // Wait 5 seconds if contended – in case another instance
            // of the program is in the process of shutting down.
            if (!mutex.WaitOne(TimeSpan.FromSeconds(5), false)) {
                Console.WriteLine("Another instance of the app is running. Bye!");
                return;
            }
            try {
                Console.WriteLine("Running - press Enter to exit");
                Console.ReadLine();
            }
            finally {
                mutex.ReleaseMutex();
            }
        }
    }
}
