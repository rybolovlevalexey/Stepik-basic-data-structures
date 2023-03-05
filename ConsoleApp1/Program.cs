using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Node
    {
        public Node Next;
        public int Value;

        public Node(int value)
        {
            Value = value;
        }
    }
    public class SinglyLinkedList
    {
        public Node Head;
        private int count = 0;
        public Node FindByIndex(int index)
        {
            // реализуйте данный метод
            int ind = 0;
            Node cur = Head;
            while (cur != null)
            {
                if (ind == index)
                    return cur;
                cur = cur.Next;
                ind += 1;
            }
            return new Node(-1);
        }
        public Node FindLast(int key)
        {
            Node ans = null;
            Node cur = Head;
            while (cur != null)
            {
                if (cur.Value == key)
                    ans = cur;
                cur = cur.Next;
            }
            return ans;
        }
        public int GetCount()
        { }

        public string Print()
        {
            
        }

        public Node Find(int key)
        {
            return new Node(-1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sp = new List<int>();
            int x = Convert.ToInt32(Console.ReadLine());
            while (x != 0)
            {
                sp.Add(x);
                x = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = sp.Count - 1; i >= 0; i -= 1)
            {
                Console.Write($"{sp[i]} ");
            }
        }
    }
}