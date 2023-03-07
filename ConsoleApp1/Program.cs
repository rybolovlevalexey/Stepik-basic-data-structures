using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> letters = new Dictionary<string, int>();
            string st = Console.ReadLine();
            for (int i = 0; i < st.Length; i += 1)
            {
                string elem = Convert.ToString(st[i]);
                if (letters.ContainsKey(elem))
                    letters[elem] += 1;
                else
                    letters[elem] = 1;
            }
            string st1 = Console.ReadLine();
            bool flag = true;
            for (int i = 0; i < st1.Length; i += 1)
            {
                string elem = Convert.ToString(st1[i]);
                if (letters.ContainsKey(elem))
                {
                    if (letters[elem] == 0)
                    {
                        flag = false;
                        break;
                    }
                    else
                        letters[elem] -= 1;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (flag && st.Length == st1.Length)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}