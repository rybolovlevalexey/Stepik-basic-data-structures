using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, List<string>> classes = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i += 1)
            {
                string[] st = Console.ReadLine().Split();
                if (classes.ContainsKey(st[0]))
                    classes[st[0]].Add(st[1]);
                else
                {
                    classes[st[0]] = new List<string>();
                    classes[st[0]].Add(st[1]);
                }
            }
            for (int cl = 9; cl <= 11; cl += 1)
            {
                if (classes.ContainsKey(Convert.ToString(cl)))
                {
                    foreach (var name in classes[Convert.ToString(cl)])
                        Console.WriteLine($"{cl} {name}");
                }
            }
        }
    }
}