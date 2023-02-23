using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string st = Console.ReadLine();
            int summa = 0;
            foreach (var elem in st)
            {
                if (elem == ' ' || elem == '-')
                    continue;
                summa += Convert.ToInt32(Convert.ToString(elem));
            }
            Console.WriteLine(summa);
        }
    }
}
