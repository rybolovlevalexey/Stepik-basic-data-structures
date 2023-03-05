using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
    {
        static void Main(string[] args)
        {
            static int Maximum(string[] numbs)
            {
                int ans = -1;
                for (int i = 0; i < numbs.Length; i += 1)
                {
                    if (i == 0)
                        ans = Convert.ToInt32(numbs[i]);
                    else
                    {
                        if (ans < Convert.ToInt32(numbs[i]))
                            ans = Convert.ToInt32(numbs[i]);
                    }
                }
                return ans;
            }
            int n = Convert.ToInt32(Console.ReadLine());
            string[] sp1 = Console.ReadLine().Split();
            int m = Convert.ToInt32(Console.ReadLine());
            string[] sp2 = Console.ReadLine().Split();
            Console.WriteLine(Maximum(sp1) * Maximum(sp2));
        }
    }
}