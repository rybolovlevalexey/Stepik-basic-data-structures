using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
    {
        static void Main(string[] args)
        {
            static bool IsGood(int numb)
            {
                SortedSet<char> sp = new SortedSet<char>();
                foreach (char elem in Convert.ToString(numb))
                {
                    sp.Add(elem);
                }
                return (sp.Count == 4);
            }
            int year = Convert.ToInt32(Console.ReadLine()) + 1;
            while (true)
            {
                if (IsGood(year))
                    break;
                year += 1;
            }
            Console.WriteLine(year);
        }
    }
}