using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sp = new List<int>();
            int x = Convert.ToInt32(Console.ReadLine());
            while (x != 0)
            {
                sp.Add(x);
                x = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = sp.Count - 1; i >= 0; i -= 1)
            {
                Console.Write($"{sp[i]} ");
            }
        }
    }
}