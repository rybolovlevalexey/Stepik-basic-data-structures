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
            int step = n - 1;
            string[] st = Console.ReadLine().Split();
            int ans = 0;
            for (int i = 0; i < n; i += 1)
            {
                if (st[i] == "1")
                    ans += Convert.ToInt32(Math.Pow(2, step));
                step -= 1;
            }
            Console.WriteLine(ans);
        }
    }
}