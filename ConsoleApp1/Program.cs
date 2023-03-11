using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //1 - I, 5 - V, 10 - X, 50 - L, 100 - C, 500 - D и 1000 - M.
    //MCMXCIV
    class Program
    {
        public static int RomanToInt(string s)
        {
            Dictionary<string, int> symbols = new Dictionary<string, int>();
            symbols["I"] = 1;
            symbols["V"] = 5;
            symbols["X"] = 10;
            symbols["L"] = 50;
            symbols["C"] = 100;
            symbols["D"] = 500;
            symbols["M"] = 1000;
            int ans = 0;
            int ind = 0, k1, k2;
            
            while (ind < s.Length)
            {
                k1 = symbols[Convert.ToString(s[ind])];
                if (ind + 1 < s.Length)
                {
                    k2 = symbols[Convert.ToString(s[ind + 1])];
                    if (k2 > k1)
                    {
                        ans += (k2 - k1);
                        ind += 1;
                    }
                    else
                        ans += k1;
                } else
                    ans += k1;
                ind += 1;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            string st = Console.ReadLine();
            Console.WriteLine(RomanToInt(st));
        }
    }
}