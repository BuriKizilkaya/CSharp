using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueb02_Events
{
    public delegate void MyEventHandler(object sender, MyEventArgs ea); 

    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(string eventData)
        {
            EventData = eventData; 
        }
        public string EventData
        {
            get; set;
        }
    }

    class EventProducer
    {
        // Event deklarieren
        public event MyEventHandler MyEvent;

        // Event "feuern"
        public void OnMyEvent(string data)
        {
            MyEvent?.Invoke(this, new MyEventArgs(data));
        }
    }

    class EventConsumer
    {
        public static int countObj = 0; 

        public EventConsumer(EventProducer producer)
        {
            producer.MyEvent += MyHandler;
        }

        private void MyHandler(object sender, MyEventArgs ea)
        {
            countObj++; 
            Console.WriteLine("EventData " + countObj + " :" + ea.EventData); 
        }

        

    }

    class Program
    {
        /// <summary>
        /// Hauptprogramm: Erzeugt einen Event-Producer sowie zwei
        /// Consumer die sich beim Event des Producers registrieren.
        /// </summary>
        public Program()
        {
            EventProducer producer = new EventProducer();
            EventConsumer consumer1 = new EventConsumer(producer);
            EventConsumer consumer2 = new EventConsumer(producer);
            producer.OnMyEvent("Event fired...");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.Read();
        }
    }

}
