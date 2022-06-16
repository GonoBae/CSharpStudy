using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegate.EventTest
{
    public delegate void MyEventHandler(string msg);
    class Publisher
    {
        public event MyEventHandler myEvent;

        public void DoEvent(int num)
        {
            if (num % 10 == 0)
                myEvent("Event" + num);
            else
                Console.WriteLine(num);
        }
    }

    class Subscriber
    {
        static public void MyHandler(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Main1()
        {
            Publisher publisher = new Publisher();
            publisher.myEvent += new MyEventHandler(MyHandler);
            
            for (int i = 1; i <= 50; i++)
                publisher.DoEvent(i);
        }
    }
}
