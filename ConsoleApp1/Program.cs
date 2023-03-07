using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> book = new Dictionary<string, string>();
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i += 1)
            {
                string[] st = Console.ReadLine().Split();
                if (!book.ContainsKey(st[1]))
                    book[st[1]] = st[0];
                else
                {
                    st[0] = " " + st[0];
                    book[st[1]] += st[0];
                }
            }
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i += 1)
            {
                string name = Console.ReadLine();
                if (book.ContainsKey(name))
                    Console.WriteLine(book[name]);
                else
                    Console.WriteLine($"Имени {name} нет в телефонной книге");
            }
        }
    }
}