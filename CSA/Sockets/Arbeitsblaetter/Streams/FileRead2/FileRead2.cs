using System;
using System.IO;

namespace FileRead {
    class FileRead2 {
        public static void Main() {
            try {
                using (StreamReader sr = new StreamReader("daten.txt")) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
