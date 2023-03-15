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
            Dictionary<string, int> ocenky = new Dictionary<string, int>();
            string[] st = Console.ReadLine().Split();
            foreach(var elem in st)
            {
                bool flag = false;
                foreach (var key in ocenky.Keys)
                {
                    if (key == elem)
                    {
                        flag = true;
                        ocenky[key] += 1;
                        break;
                    }
                }
                if (!flag)
                    ocenky[elem] = 1;
            }
            foreach (var key in ocenky.Keys)
            {
                if (ocenky[key] == n)
                {
                    Console.WriteLine(key);
                    break;
                }
            }
        }
    }
}