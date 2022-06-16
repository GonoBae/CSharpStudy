using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegate.EventTest1
{
    delegate void DelegateType(string msg);

    class A
    {
        public event DelegateType EventHandler;
        public void func(string msg)
        {
            EventHandler(msg);
        }
    }

    class B
    {
        public void PrintA(string msg)
        {
            Console.WriteLine("PrintA : " + msg);
        }

        public void PrintB(string msg)
        {
            Console.WriteLine("PrintB : " + msg);
        }
    }

    class MainApp
    {
        static void Main1()
        {
            A a = new A();
            B b = new B();

            a.EventHandler += new DelegateType(b.PrintA);
            a.EventHandler += new DelegateType(b.PrintB);

            a.func("Good!");
            a.EventHandler -= b.PrintB;
            a.func("Hi!");
            a.EventHandler -= b.PrintA;


        }
    }
}
