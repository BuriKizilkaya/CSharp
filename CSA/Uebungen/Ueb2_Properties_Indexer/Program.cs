using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueb2_Properties_Indexer
{
    class StringList
    {
        private string[] data;
        
        // Constructor
        public StringList()
        {
            //data = new string[0];
        }

        public int Size
        {
            get { return data.Length; }
            set
            {
                data = new string[value];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = "empty"; 
                }
            }
        }

        public string[] Data
        {
            get { return data; }
        }

        public string this[int index]
        {
            get { return this.Data[index]; }
            set { this.Data[index] = value; }
        }

        
    }



    class Program
    {
        static void Main(string[] args)
        {
            StringList sl = new StringList();
            // Int-Property (setzt die Grösse der Liste)
            sl.Size = 5;
            Console.WriteLine("Size: " + sl.Size);
            // Zugriff auf Array über (Array-)Property
            sl.Data[1] = "Some value";
            sl.Data[3] = "Another value";
            foreach (string s in sl.Data)
            {
                Console.WriteLine("entry: " + s);
            }
            Console.WriteLine();

            // Zugriff auf Array über Indexer
            sl[4] = "Something else";
            sl[0] = sl[1] + ", " + sl[3];
            for (int i = 0; i < sl.Size; i++)
            {
                Console.WriteLine("entry[" + i + "]: " + sl[i]);
            }
            Console.Read();
        }
    }
}
