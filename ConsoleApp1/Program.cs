using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, List<string>> persons = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i += 1)
            {
                string[] st = Console.ReadLine().Split();
                if (!persons.ContainsKey(st[2]))
                    persons[st[2]] = new List<string>();
                persons[st[2]].Add(st[0]);
            }
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i += 1)
            {
                string month = Console.ReadLine();
                if (!persons.ContainsKey(month))
                    Console.WriteLine("-");
                else
                {
                    foreach (var name in persons[month])
                        Console.Write($"{name} ");
                    Console.WriteLine();
                }
            }
        }
    }
}