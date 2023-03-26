using System;
using System.Collections.Generic;
using System.Collections;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            Solution sl = new Solution(l1, l2);

        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public Solution(ListNode list1, ListNode list2)
        {
            Console.WriteLine(MergeTwoLists(list1, list2));
        }
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode Head = new ListNode();
            if (list1 is null && list2 is null)
                return null;
            if (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    Head.val = list1.val;
                    list1 = list1.next;
                } else
                {
                    Head.val = list2.val;
                    list2 = list2.next;
                }
            } else
            {
                if (list1 is null)
                {
                    Head.val = list2.val;
                    list2 = list2.next;
                }
                else
                {
                    Head.val = list1.val;
                    list1 = list1.next;
                }
            }

            ListNode cur_head = Head;
            while (list1 != null || list2 != null)
            {
                if (list1 != null && list2 != null)
                {
                    if (list1.val < list2.val)
                    {
                        ListNode cur = new ListNode(list1.val);
                        list1 = list1.next;
                        cur_head.next = cur;
                    } else
                    {
                        ListNode cur = new ListNode(list2.val);
                        list2 = list2.next;
                        cur_head.next = cur;
                    }
                    cur_head = cur_head.next;
                } else
                {
                    if (list1 is null)
                    {
                        ListNode cur = new ListNode(list2.val);
                        list2 = list2.next;
                        cur_head.next = cur;
                    } else
                    {
                        ListNode cur = new ListNode(list1.val);
                        list1 = list1.next;
                        cur_head.next = cur;
                    }
                }
                
            }
            return Head;
        }
    }
}