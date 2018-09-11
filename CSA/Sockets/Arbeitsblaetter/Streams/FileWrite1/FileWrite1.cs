using System;
using System.IO;

namespace FileWrite1 {
    class FileWrite1 {
        public static void Main() {
            StreamWriter sw = null;
            try {
                FileStream fs = new FileStream("daten.txt", FileMode.Create);
                sw = new StreamWriter(fs);
                string[] text = { "Titel", "Köln", "4711" };
                for (int i = 0; i <= text.Length; i++)
                    sw.WriteLine(text[i]);
                Console.WriteLine("fertig.");
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            finally {
                sw.Close();
            }
        }
    }
}
