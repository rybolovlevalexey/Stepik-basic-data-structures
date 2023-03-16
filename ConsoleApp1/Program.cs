using System;
using System.Collections.Generic;
using System.Collections;


namespace ConsoleApp1
{
    class Program
    {
		static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            LinkedList<string> first = new LinkedList<string>(Console.ReadLine().Split());
            int m = Convert.ToInt32(Console.ReadLine());
            LinkedList<string> second = new LinkedList<string>(Console.ReadLine().Split());
            LinkedListNode<string> cur1 = first.First, cur2 = second.First;
            while (cur1 != null || cur2 != null)
            {
                if (cur1 == null)
                {
                    Console.Write(cur2.Value + " ");
                    cur2 = cur2.Next;
                } else if(cur2 == null)
                {
                    Console.Write(cur1.Value + " ");
                    cur1 = cur1.Next;
                } else if (Convert.ToInt32(cur1.Value) < Convert.ToInt32(cur2.Value))
                {
                    Console.Write(cur1.Value + " ");
                    cur1 = cur1.Next;
                } else
                {
                    Console.Write(cur2.Value + " ");
                    cur2 = cur2.Next;
                }
            }
        }
    }
}