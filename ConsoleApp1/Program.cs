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
            LinkedList<string> ans = new LinkedList<string>();
            string[] st = Console.ReadLine().Split();
            string last = "";
            foreach(string elem in st)
            {
                if (elem != last)
                {
                    ans.AddLast(elem);
                    last = elem;
                }
            }
            foreach (var elem in ans)
                Console.Write(elem + " ");
        }
    }
}