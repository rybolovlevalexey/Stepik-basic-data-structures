using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static public int[] GetCubes(int start, int end)
        {
            int[] ans = new int[end - start + 1];
            int ind = 0;
            for (int num = start; num <= end; num += 1)
            {
                ans[ind] = num * num * num;
                ind += 1;
            }
            return ans;
        }
        static public void PrintSum(int[] sp)
        {
            int summ = 0;
            foreach (var elem in sp)
                summ += elem;
            Console.WriteLine(summ);
        }
        static void Main(string[] args)
        {
            int startValue = int.Parse(Console.ReadLine());
            int endValue = int.Parse(Console.ReadLine());
            PrintSum(GetCubes(startValue, endValue));
        }
    }
}