using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
    {
        static void Main(string[] args)
        {
            static bool IsProst(int numb)
            {
                for (int d = 2; d <= numb / 2; d += 1)
                {
                    if (numb % d == 0)
                        return false;
                }
                return true;
            }
            int n = Convert.ToInt32(Console.ReadLine());
            if (IsProst(n))
                Console.WriteLine("prime");
            else
                Console.WriteLine("composite");
        }
    }
}