using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string st = Console.ReadLine();
            int cnt = 0;
            while (st.Contains("xxx"))
            {
                cnt += 1;
                st = st[0..(st.IndexOf("xxx") + 1)] + st[(st.IndexOf("xxx") + 2)..(st.Length)];
            }
            Console.WriteLine(cnt);
        }
    }
}