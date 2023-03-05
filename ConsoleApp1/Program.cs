using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
    {
        static void Main(string[] args)
        {
            static bool IsGood(string numb)
            {
                if (Convert.ToInt32(numb[0]) + Convert.ToInt32(numb[1]) + Convert.ToInt32(numb[2]) == Convert.ToInt32(numb[3]) + Convert.ToInt32(numb[4]) + Convert.ToInt32(numb[5]))
                    return true;
                return false;
            }
            string x1 = (Console.ReadLine());
            string x2 = (Console.ReadLine());
            if (IsGood(x1) && IsGood(x2))
                Console.WriteLine(1);
            else
                Console.WriteLine(-1);
        }
    }
}