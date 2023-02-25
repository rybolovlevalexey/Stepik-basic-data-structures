using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] st = Console.ReadLine().Split();
            int[] sp = new int[n];
            for (int i = 0; i < n; i++)
                sp[i] = Convert.ToInt32(st[i]);
            int mn = 0, mx = 0, mni = 0, mxi = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || sp[i] > mx)
                {
                    mx = sp[i];
                    mxi = i;
                }
                if (i == 0 || sp[i] < mn)
                {
                    mn = sp[i];
                    mni = i;
                }
            }
            int summa = 0, a= 0 , b = 0;
            if (mni < mxi)
            {
                a = mni;
                b = mxi;
            }
            if (mni > mxi)
            {
                a = mxi;
                b = mni;
            }
            for (int i = a + 1; i < b; i++)
                summa += sp[i];
            Console.WriteLine(summa);
        }
    }
}