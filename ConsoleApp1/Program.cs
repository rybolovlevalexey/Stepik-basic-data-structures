using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0, n = 0;
            string st = Console.ReadLine();
            MyStack stck = new MyStack();
            foreach (var elem in st)
            {
                if (elem == '(')
                    n += 1;
                else
                {
                    if (n == 0)
                        cnt += 1;
                    else
                        n -= 1;
                }
            }
            cnt += n;
            Console.WriteLine(cnt);
        }
    }
    class MyStack
    {
        StackItem first;
        int size = 1;
        public int Size
        {
            set
            { size = value; }
            get { return size; }
        }
        public MyStack()
        {
            first = null;
            size = 0;
        }
        public MyStack(string elem)
        {
            first = new StackItem(elem);
            size = 1;
        }
        public void append(string st)
        {
            if (size > 0)
            {
                StackItem cur = first;
                while (cur.next != null)
                {
                    cur = cur.next;
                }
                cur.next = new StackItem(st);
                size = size + 1;
            }
            else
            {
                first = new StackItem(st);
                size = 1;
            }

        }
        public StackItem pop()
        {
            StackItem cur = first;
            if (size == 1 || size == 0)
            {
                if (size == 0)
                    return null;
                size = size - 1;
                first = null;
                return cur;
            }
            size = size - 1;
            while (cur.next.next != null)
            {
                cur = cur.next;
            }
            StackItem ans = cur.next;
            cur.next = null;
            return ans;
        }
    }

    class StackItem
    {
        public string value;
        public StackItem next = null;

        public StackItem(string st)
        {
            value = st;
        }
    }
}