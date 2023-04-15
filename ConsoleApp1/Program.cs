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
            int[] can_doh = new int[n];
            int[] can_obr = new int[n];
            int[] can_chi = new int[n];
            string[] doh = Console.ReadLine().Split();
            string[] obr = Console.ReadLine().Split();
            string[] chi = Console.ReadLine().Split();
            for (int i = 0; i < n; i += 1)
            {
                can_doh[i] = Convert.ToInt32(doh[i]);
                can_obr[i] = Convert.ToInt32(obr[i]);
                can_chi[i] = Convert.ToInt32(chi[i]);
            }
            int q = Convert.ToInt32(Console.ReadLine());
            string[] dohod = Console.ReadLine().Split();
            string[] obraz = Console.ReadLine().Split();
            string[] parents = Console.ReadLine().Split();
            for (int i = 0; i < q; i += 1)
            {
                int dj = Convert.ToInt32(dohod[i]), oj = Convert.ToInt32(obraz[i]), pj = Convert.ToInt32(parents[i]);
                int ans = 0;
                if (pj != 0 && can_chi[pj - 1] != 0)
                    ans = pj;
                for (int j = 0; j < n; j += 1)
                {
                    if (dj >= can_doh[j] && oj >= can_obr[j])
                    {
                        if (ans > j + 1 || ans == 0)
                            ans = j + 1;
                        break;
                    }
                }
                Console.Write($"{ans} ");
            }
        }
    }
}