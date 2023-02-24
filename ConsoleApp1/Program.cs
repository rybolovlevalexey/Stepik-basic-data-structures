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

    }

    class DequeElem
    {
        string value;
        DequeElem prev = null, next = null;

        public DequeElem(string x)
        {
            value = x;
        }
    }
}