using System;
using System.Collections.Generic;
using System.Collections;


namespace ConsoleApp1
{
    class Program
    {
        static void print_info(LinkedList<int> sp, LinkedListNode<int> mid)
        {
            foreach (var el in sp)
                Console.Write(el + " ");
            if (mid != null)
                Console.Write(mid.Value);
            else
                Console.Write("None");
            Console.WriteLine();
        }
		static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            LinkedList<int> goblins = new LinkedList<int>();
            LinkedListNode<int> middle = goblins.First;
            for (int i = 0; i < n; i += 1)
            {
                string st = Console.ReadLine();
                
                if (goblins.Count == 1)
                    middle = goblins.First;
                if (st.Contains(" "))
                {
                    int gob_num = Convert.ToInt32(st.Split()[1]);
                    if (st.Split()[0] == "+")
                    {
                        goblins.AddLast(Convert.ToInt32(st.Split()[1]));
                        if (goblins.Count % 2 == 0)
                            middle = middle.Next;
                    } else
                    {
                        if (goblins.Count == 0)
                        {
                            goblins.AddLast(gob_num);
                            middle = goblins.First;
                        }
                           
                        else
                        {
                            if (goblins.Count % 2 == 0)
                            {
                                goblins.AddBefore(middle, gob_num);
                                middle = middle.Next;
                            }
                            else
                            {
                                goblins.AddAfter(middle, gob_num);
                                middle = middle.Next;
                            }
                        }
                        
                    }
                } else
                {
                    Console.WriteLine(goblins.First.Value);
                    goblins.RemoveFirst();
                    if (goblins.Count % 2 != 0)
                        middle = middle.Next;
                }
                print_info(goblins, middle);
            }
            foreach (var el in goblins)
                Console.Write(el + " ");
        }
    }
}