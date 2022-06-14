using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class MyStack<T>
    {
        T[] array = new T[] { };
        int iIdx;
        public MyStack()
        {
            array = new T[100];
            iIdx = -1;
        }
        public void Push(T data)
        {
            array[++iIdx] = data;
        }
        public T Pop()
        {
            return array[iIdx--];
        }
        public T Top()
        {
            return array[iIdx];
        }
        public int Size()
        {
            return iIdx + 1;
        }
    }
    //class Program
    //{
    //    static void Main()
    //    {
    //        MyStack<int> stack = new MyStack<int>();
    //        stack.Push(1);
    //        stack.Push(2);
    //        stack.Push(3);
    //        Console.WriteLine(stack.Size());
    //        Console.WriteLine(stack.Pop());
    //        Console.WriteLine(stack.Pop());
    //        Console.WriteLine(stack.Top());
    //        Console.WriteLine(stack.Size());
    //    }
    //}
}
