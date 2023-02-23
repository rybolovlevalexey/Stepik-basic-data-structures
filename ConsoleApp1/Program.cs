using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] st = Console.ReadLine().Split();
            int mn = 0, mx = 0, ind_mn = -1, ind_mx = -1;
            for (int i = 0; i < st.Length; i++)
            {
                if (ind_mn == -1)
                {
                    ind_mn = 0;
                    ind_mx = 0;
                    mn = Convert.ToInt32(Convert.ToString(st[i]));
                    mx = Convert.ToInt32(Convert.ToString(st[i]));
                } else
                {
                    int elem = Convert.ToInt32(Convert.ToString(st[i]));
                    if (elem < mn)
                    {
                        mn = elem;
                        ind_mn = i;
                    }
                    if (elem > mx)
                    {
                        mx = elem;
                        ind_mx = i;
                    }
                }
            }
            for (int i = 0; i < st.Length; i += 1)
            {
                if (i == ind_mn && i != ind_mx)
                {
                    Console.Write($"{mx} ");
                }
                if (i == ind_mx && i != ind_mn)
                {
                    Console.Write($"{mn} ");
                }
                if (i != ind_mn && i != ind_mx){
                    Console.Write($"{st[i]} ");
                }
            }
        }
    }
}
