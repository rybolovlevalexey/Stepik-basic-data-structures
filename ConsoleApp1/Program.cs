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
            List<string> keys = new List<string>(letters.Keys);
            keys.Sort();
            foreach(string key in keys)
            {
                Console.WriteLine($"{key} {letters[key]}");
            }
        }
    }
}