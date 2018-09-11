using System;
using System.IO;

namespace FileRead1 {
    class FileRead1 {
        public static void Main() {
            try {
                string line;
                FileStream fs = new FileStream("daten.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                while ((line = sr.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
                sr.Close();
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
