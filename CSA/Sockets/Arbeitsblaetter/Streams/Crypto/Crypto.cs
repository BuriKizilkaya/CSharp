using System;
using System.IO;
using System.Security.Cryptography;

namespace Crypto {
    class Crypto {
        public static void Main() {
            Stream stm = new FileStream("daten.txt", FileMode.Open, FileAccess.Read);
            ICryptoTransform ict = new ToBase64Transform();
            CryptoStream cs = new CryptoStream(stm, ict, CryptoStreamMode.Read);
            TextReader tr = new StreamReader(cs);
            string s = tr.ReadToEnd();
            Console.WriteLine(s);
        }
    }
}
