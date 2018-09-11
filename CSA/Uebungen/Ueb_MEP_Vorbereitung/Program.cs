using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ueb_MEP_Vorbereitung
{
    class Program
    {   

        static void Main(string[] args)
        {
            byte result = 0 ;
            byte mp1, mp2, mp3, mp4;

            Console.WriteLine(result);

            mp1 = 1 & (1 << 0);
            mp2 = 1 & (1 << 0);
            mp3 = 2 & (2 << 1);
            mp4 = 2 & (1 << 1);

            result = (byte)((mp4 << 2) | (mp3 << 1) | (mp2 << 1) | (mp1 << 0));

            Console.WriteLine(result);
            Console.ReadKey();    
        }
        
    }
}
