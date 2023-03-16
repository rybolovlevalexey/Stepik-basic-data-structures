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
            LinkedList<string> elements = new LinkedList<string>(Console.ReadLine().Split());
            Stack<(int, int)> stack = new Stack<(int, int)>();  // tuple(value, index)
            int[] ans = new int[elements.Count];
            int ind = 0;
            foreach(var elem in elements)
            {
                int value = Convert.ToInt32(elem);
                while (stack.Count > 0 && value > stack.Peek().Item1)
                {
                    ans[stack.Peek().Item2] = value;
                    stack.Pop();
                }
                (int, int) tup = (value, ind);
                stack.Push(tup);
                ind += 1;
            }
            foreach (var el in ans)
                Console.Write(el + " ");
        }
    }
}