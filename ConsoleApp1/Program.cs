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
            
            Queue<int> goblins = new Queue<int>();
            for (int i = 0; i < n; i += 1)
            {
                string st = Console.ReadLine();
                if (st.Contains(" "))
                {
                    if (st.Split()[0] == "+")
                    {
                        goblins.Enqueue(Convert.ToInt32(st.Split()[1]));
                    } else
                    {
                        List<int> a_goblins = new List<int>(goblins.ToArray());
                        if (goblins.Count % 2 == 0)
                        {
                            a_goblins.Insert(goblins.Count / 2, Convert.ToInt32(st.Split()[1]));
                        } else
                        {
                            a_goblins.Insert(goblins.Count / 2 + 1, Convert.ToInt32(st.Split()[1]));
                        }
                        goblins = new Queue<int>(a_goblins);
                    }
                } else
                {
                    int value = goblins.Dequeue();
                    Console.WriteLine(value);
                }
            }
        }
    }
}