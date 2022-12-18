using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Stack
    {
        StackItem first;
        int size = 0;
        public Stack(string elem)
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
                size += 1;
            } else
            {
                first = new StackItem(st);
            }
            
        }
        public StackItem pop()
        {
            StackItem cur = first;
            if (size == 1 || size == 0)
            {
                if (size == 0)
                    return null;
                size -= 1;
                first = null;
                return cur;
            } 
            size -= 1;
            while(cur.next.next != null)
            {
                cur = cur.next;
            }
            StackItem ans = cur.next;
            cur.next = null;
            return ans;
        }
    }
}
