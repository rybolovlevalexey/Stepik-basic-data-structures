using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static public void Factorize(int numb)
        {
            for (int d = 1; d <= Convert.ToInt32(Math.Sqrt(numb)); d += 1)
            {
                if (numb % d == 0)
                    Console.WriteLine($"{numb} = {d} * {numb / d}");
            }
        }
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            Factorize(value);
        }
    }
}