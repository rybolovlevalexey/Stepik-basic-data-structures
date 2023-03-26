using System;
using System.Collections.Generic;
using System.Collections;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution("()[]{ }");

        }
    }
    public class Solution
    {
        public Solution(string st)
        {
            Console.WriteLine(IsValid(st));
        }
        public bool IsValid(string s)
        {
            Stack<char> stck = new Stack<char>();
            foreach (var el in s)
            {
                if (!"{}[]()".Contains(el))
                    continue;
                if (el == '{' || el == '(' || el == '[')
                    stck.Push(el);
                else
                {
                    char elem = '0';
                    switch (el)
                    {
                        case ')':
                            elem = '(';
                            break;
                        case '}':
                            elem = '{';
                            break;
                        case ']':
                            elem = '[';
                            break;
                    }
                    if (stck.Count == 0 || Convert.ToString(elem) != Convert.ToString(stck.Peek()))
                    {
                        return false;
                    }
                        
                    else
                        stck.Pop();
                }
            }
            return stck.Count == 0;
        }
    }
}