using System;

namespace Ueb1
{
    public class ClassA
    {        
        public ClassA()//Default Konstruktor
        {

        }

        public ClassA(string msg)
        {
            Console.WriteLine("\nA:" + msg + " "); 
        }
    }

    //**************************************************************
    public class ClassB: ClassA
    {
        public ClassB(string msg, int count)
        {
            Console.Write("B:" + msg); 

            for(int i = 0; i<count; i++)
            {
                Console.Write(".");
            }
            Console.Write(" "); 
        }

        public ClassB(string msg):this(msg, 1){}

        public ClassB():this("B0", 0) {}
    }

    //**************************************************************
    public class Application
    {
        static void Main(string[] args)
        {
            ClassA A = new ClassA("A");
            ClassB B0 = new ClassB();
            ClassB B1 = new ClassB("B1");
            ClassB B2 = new ClassB("B2", 2);

            ClassA AA = new ClassA("AA");
            ClassA AB = new ClassB("AB");

            Console.Read();
        }
    }
    
}


