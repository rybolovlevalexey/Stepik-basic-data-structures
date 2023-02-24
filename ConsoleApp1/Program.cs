using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Deque deq = new Deque();
            string st = Console.ReadLine();
            while (st != "exit")
            {

            }
        }
    }

    class Deque
    {
        DequeElem Head = null;

        public void push_back(string elem)
        {
            if (Head is null)
                Head = new DequeElem(elem);
            else
            {
                DequeElem cur = Head;
                while (!(cur.next is null))
                    cur = cur.next;
                cur.next = new DequeElem(elem);
            }
            Console.WriteLine("ok");
        }

        public void push_front(string elem)
        {
            if (Head is null)
                Head = new DequeElem(elem);
            else
            {
                DequeElem cur = Head;
                DequeElem new_elem = new DequeElem(elem);
                new_elem.next = cur;
                Head = new_elem;
            }
            Console.WriteLine("ok");
        }
    }

    class DequeElem
    {
        public string value;
        public DequeElem prev = null, next = null;

        public DequeElem(string x)
        {
            value = x;
        }
    }
}