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
    }
    class Program
    {
		static void Main(string[] args)
        {
            
        }
    }
}