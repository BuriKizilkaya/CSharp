using System;
using System.Threading;

namespace ThreadStop1 {

    class ThreadStop1 {

        static void Main() {
            try {
                new Thread(Go).Start();
            }
            catch (Exception ex) {
                Console.WriteLine("Exception! " + ex.Message);
            }
            Console.WriteLine("end...");
        }
        static void Go() {
            throw null;    // NullReferenceException wird ausgelöst
            Console.WriteLine("uups!");
        }
    }
}
