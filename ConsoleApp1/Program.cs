using System;
using System.Collections.Generic;
using System.Collections;


namespace ConsoleApp1
{
    public class Node
    {
        public Node Next;
        public int Value;
        public Node Previous;

        public Node(int value)
        {
            Value = value;
        }
    }
    public class SinglyLinkedList
    {
        public Node Head;
        public Node Tail;
        private int count = 0;
        public bool Remove(int item)
        {
            // реализуйте данный метод
            Node cur = Head;
            if (count == 0)
                return false;
            if (count == 1)
            {
                if (Head.Value == item)
                {
                    Head = null;
                    return true;
                }
                else
                    return false;
                
            }
            while (cur != null)
            {
                if (cur.Value == item)
                {
                    cur.Next.Previous = cur.Previous;
                    cur.Previous.Next = cur.Next;
                    return true;
                }
                cur = cur.Next;
            }
            return false;
        }
        public void AddAfter(Node node, int item)
        {
            // реализуйте данный метод
            if (node == null)
                return;
            if (count == 0)
            {
                Head = new Node(item);
                return;
            }
            Node new_elem = new Node(item);
            new_elem.Previous = node;
            new_elem.Next = node.Next;

            new_elem.Previous.Next = new_elem;
            new_elem.Next.Previous = new_elem;
        }
        public Node FindLast(int key)
        {
            // реализуйте данный метод
            if (count == 0)
                return null;
            Node ans = new Node(-1);
            bool flag = false;
            Node cur = Head;
            while (cur != null)
            {
                if (cur.Value == key)
                {
                    flag = true;
                    ans = cur;
                }
                cur = cur.Next;
            }
            if (flag)
                return ans;
            return null;
        }
        public void AddBefore(Node node, int item)
        {
            // реализуйте данный метод
            if (count == 0)
            {
                Tail = new Node(item);
                return;
            }
            if (node == Tail && Tail.Next == null)
            {
                PushFront(item);
                return;
            }
            Node cur = Tail;
            do
            {
                cur = cur.Next;
            } while (cur != Tail && cur.Next != node);
            Node new_node = new Node(item);
            new_node.Next = cur.Next;
            cur.Next = new_node;
        }
        public int GetCount()
        { return count; }

        public string Print()
        {
            string ans = "";
            Node cur = Head;
            while (!(cur is null)){
                ans += (Convert.ToString(cur)+ " ");
                cur = cur.Next;
            }
            return ans;
        }

        public Node Find(int key)
        {
            Node cur = Head;
            while (!(cur is null))
            {
                if (cur.Value == key)
                    return cur;
                cur = cur.Next;
            }
            return cur;
        }

        public void PushBack(int item)
        {
            Node cur = Head;
            while (!(cur.Next is null))
            {
                cur = cur.Next;
            }
            cur.Next = new Node(item);
            count += 1;
        }

        public void PushFront(int item)
        {
            Node cur = new Node(item);
            cur.Next = Head;
            Head = cur;
            count += 1;
        }

        public void AddAfter(Node node, int item)
        {
            Node new_node = new Node(item);
            new_node.Next = node.Next;
            node.Next = new_node;
            count += 1;
        }
    }
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
        public int count()
        {
            return size;
        }
    }
    class Program
    {
		static void Main(string[] args)
        {
            Queue que = new Queue();
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i += 1)
            {
                string st = Console.ReadLine();
                if (st == "-")
                {
                    que.dequeue();
                } else
                {
                    if (st.Split()[0] == "+")
                    {
                        que.enqueue(st.Split()[1]);
                    } else
                    {
                        int dl = que.count();
                        if (dl % 2 == 0)
                        {
                            que.items.Insert(dl / 2, st.Split()[1]);
                        } else
                        {
                            que.items.Insert(dl / 2 + 1, st.Split()[1]);
                        }
                    }
                }

            }
        }
    }
}