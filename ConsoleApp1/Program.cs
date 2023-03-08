using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> persons = new Dictionary<string, int>();
            for (int i = 0; i < n; i += 1)
            {
                string st = Console.ReadLine();
                bool flag = true;
                if (!persons.ContainsKey(st))
                    flag = false;
                if (!flag)
                {
                    Console.WriteLine("OK");
                    persons[st] = 1;
                } else
                {
                    Console.WriteLine(st + Convert.ToString(persons[st]));
                    persons[st] += 1;
                }
            }    
        }
    }
}