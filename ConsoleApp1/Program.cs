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
            Dictionary<string, string> words = new Dictionary<string, string>();
            for(int i = 0; i < n; i += 1)
            {
                string st = Console.ReadLine();
                int ind = st.IndexOf(" ");
                words[st[0..ind]] = st[(ind+1)..];
            }
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i += 1)
            {
                string st = Console.ReadLine();
                bool flag = false;
                foreach (var key in words.Keys)
                {
                    if (key == st)
                    {
                        flag = true;
                        Console.WriteLine(words[key]);
                    }
                }
                if (!flag)
                    Console.WriteLine("Нет в словаре");
            }
        }
    }
}