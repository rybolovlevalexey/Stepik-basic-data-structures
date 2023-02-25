using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string st = Console.ReadLine();
            while (st.Contains(" "))
                st = st.Replace(" ", "");           
            while (st.Contains("00"))
                st = st.Replace("00", "0");
            string[] stroka = st.Split("0");
            int ans = 0;
            foreach (var elem in stroka)
            {
                if (elem.Length > ans)
                    ans = elem.Length;
            }
            Console.WriteLine(ans);
        }
    }
}