using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    class Node<T>
    {
        public T value;
        public Node<T> next;
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    class MyQueue<T>
    {
        Node<T> first = null;
        Node<T> last = null;

        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            if (last == null) first = last = node;
            else
            {
                last.next = node;
                last = node;
            }
        }

        public T Dequeue()
        {
            if(first == null) return default(T);
            else
            {
                T value = first.value;
                first = first.next;
                return value;
            }
        }

    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        MyQueue<int> queue = new MyQueue<int>();
    //        queue.Enqueue(1);
    //        queue.Enqueue(2);
    //        Console.WriteLine(queue.Dequeue());
    //        Console.WriteLine(queue.Dequeue());
    //    }
    //}
}
