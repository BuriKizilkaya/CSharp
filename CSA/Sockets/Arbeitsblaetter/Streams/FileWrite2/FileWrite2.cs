using System;
using System.IO;

namespace FileWrite {
    class FileWrite2 {
        public static void Main() {
            try {
                using (StreamWriter sw = new StreamWriter("daten.txt")) {
                    string[] text = { "Titel", "Köln", "4711" };
                    for (int i = 0; i <= text.Length; i++)
                        sw.WriteLine(text[i]);
                }
                Console.WriteLine("fertig.");
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}
