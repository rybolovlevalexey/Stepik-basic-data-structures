using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //1 - I, 5 - V, 10 - X, 50 - L, 100 - C, 500 - D и 1000 - M.
    //MCMXCIV
    class Program
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string ans = strs[0];
            for (int i = 0; i < strs.Length; i += 1)
            {
                int dl = 0;
                if (ans.Length == 0)
                    return ans;
                foreach (var elem in strs[i])
                {
                    if (dl >= ans.Length)
                        break;
                    if (elem == ans[dl])
                        dl += 1;
                    else
                        break;
                }
                if (dl == 0)
                    return "";
                ans = ans[0..dl];
            }
            return ans;
        }
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            Console.WriteLine(LongestCommonPrefix(array));
        }
    }
}