using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyLinkedList<T>
{
    class Node
    {
        public T data;
        public Node next;
        public Node(T d)
        {
            data = d;
            this.next = null;
        }
    }

    private Node head;
    public int Count { get; private set; }

    public void Add(T d)
    {
        if(Count == 0) head = new Node(d);
        else
        {
            Node curr = head;
            while(curr.next != null)
                curr = curr.next;
            curr.next = new Node(d);
        }
        Count++;
    }
}

class Program
{
    static void Main2()
    {
        MyLinkedList<int> linkedList = new MyLinkedList<int>();
        linkedList.Add(1);
        linkedList.Add(2);
        linkedList.Add(3);
    }
}
