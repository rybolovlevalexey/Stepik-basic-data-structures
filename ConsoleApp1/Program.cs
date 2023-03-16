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
            LinkedList<string> apps = new LinkedList<string>();
            for(int i = 0; i < n; i += 1)
            {
                string st = Console.ReadLine();
                if (st.StartsWith("Run"))
                {
                    string name = st[4..];
                    apps.AddFirst(name);
                } else
                {
                    string[] deyst = st.Split("+");
                    int ind = (deyst.Length - 1) % apps.Count + 1;
                    LinkedListNode<string> cur = apps.First;
                    for (int j = 0; j < ind - 1; j += 1)
                        cur = cur.Next;
                    apps.Remove(cur);
                    apps.AddFirst(cur);
                }
                Console.WriteLine(apps.First.Value);
            }
        }
    }
}