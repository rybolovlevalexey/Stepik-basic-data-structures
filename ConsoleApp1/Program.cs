using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] st = Console.ReadLine().Split();
            int cnt = 0;
            for (int ind = 0; ind < n; ind++)
            {
                if (st[ind] == "0")
                    cnt += 1;
                else Console.Write($"{st[ind]} ");
            }
            for (int ind = 0; ind < cnt; ind += 1)
                Console.Write("0 ");
        }
    }
}