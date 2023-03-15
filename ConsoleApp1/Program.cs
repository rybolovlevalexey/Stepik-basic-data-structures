using System;
using System.Collections.Generic;
using System.Collections;


namespace ConsoleApp1
{
    class Queue
    {
        public List<string> items;
        private int size = 0;
        public Queue()
        {
            items = new List<string>();
            int size = 0;
        }
        public void enqueue(string value)
        {
            items.Add(value);
            size += 1;
            Console.WriteLine("ok");
        }
        public void dequeue()
        {
            string ans = "error";
            if (size > 0)
            {
                ans = items[0];
                size -= 1;
                items.RemoveAt(0);
            }
            Console.WriteLine(ans);
        }
        public void peek()
        {
            if (size == 0)
            {
                Console.WriteLine("error");
                return;
            }
            Console.WriteLine(items[0]);
        }
        public void count()
        {
            Console.WriteLine(size);
        }
        public void clear()
        {
            size = 0;
            items = new List<string>();
            Console.WriteLine("ok");
        }
        public void exit()
        {
            Console.WriteLine("bye");
        }
    }
    class Program
    {
		static void Main(string[] args)
        {
            Queue que = new Queue();
            string st = Console.ReadLine();
            while (st != "exit")
            {
                if (st.Contains(" "))
                {
                    que.enqueue(st.Split()[1]);
                } else
                {
                    switch (st)
                    {
                        case "dequeue":
                            que.dequeue();
                            break;
                        case "peek":
                            que.peek();
                            break;
                        case "count":
                            que.count();
                            break;
                        case "clear":
                            que.clear();
                            break;
                    }
                }
                st = Console.ReadLine();
            }
            que.exit();
        }
    }
}