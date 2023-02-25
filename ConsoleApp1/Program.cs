using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int FindLast(int key, int[] items)
        {
            // реализуйте данный метод
            for(int i = items.Length - 1; i >= 0; i -= 1)
            {
                if (Convert.ToInt32(items[i]) == key)
                    return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] sp = { 6, 6, 5, 7 };
            Console.WriteLine(FindLast(0, sp));
        }
    }
}