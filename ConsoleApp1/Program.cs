using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
    {
        static void Main(string[] args)
        {
            static string MakeGood(string stroka)
            {
                if (stroka.Length <= 10)
                    return stroka;
                return stroka[0] + Convert.ToString(stroka.Length - 2) + stroka[stroka.Length - 1];
            }
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i += 1)
            {
                string st = Console.ReadLine();
                Console.WriteLine(MakeGood(st));
            }
        }
    }
}