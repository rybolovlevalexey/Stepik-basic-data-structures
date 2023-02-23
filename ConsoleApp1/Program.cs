using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt1 = 0; // ()
            int cnt2 = 0; // []
            int cnt3 = 0; // {}
            string st = Console.ReadLine();
            MyStack stck = new MyStack();
            bool flag = true;
            foreach (var ele in st)
            {
                string elem = Convert.ToString(ele);
                if (elem == "(" || elem == "[" || elem == "{")
                {
                    if (elem == "(")
                        cnt1 += 1;
                    if (elem == "[")
                        cnt2 += 1;
                    if (elem == "{")
                        cnt3 += 1;
                }
                
                else
                {
                    if (cnt1 == 0 && cnt2 == 0 && cnt3 == 0)
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        if ((cnt1 == 0 && elem == ")") || (cnt2 == 0 && elem == "]") || (cnt3 == 0 && elem == "}"))
                        {
                            flag = false;
                            break;
                        }
                        if (elem == ")")
                            cnt1 -= 1;
                        if (elem == "]")
                            cnt2 -= 1;
                        if (elem == "}")
                            cnt3 -= 1;
                    }
                }
            }

            if (cnt1 == 0 && cnt2 == 0 && cnt3 == 0 && flag)
                Console.WriteLine($"YES");
            else
                Console.WriteLine($"NO");
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
        public StackItem peek()
        {
            StackItem cur = first;
            while (cur.next != null)
            {
                cur = cur.next;
            }
            return cur;
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