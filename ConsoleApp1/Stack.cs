using System;
using System.Collections.Generic;
using System.Text;
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