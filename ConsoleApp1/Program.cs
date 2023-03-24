using System;
using System.Collections.Generic;
using System.Collections;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info_st = Console.ReadLine().Split();
            int n = Convert.ToInt32(info_st[0]);
            int m = Convert.ToInt32(info_st[1]);
            int q = Convert.ToInt32(info_st[2]);
            Dictionary<int, List<int>> disabled = new Dictionary<int, List<int>>();
            int[] sp_a = new int[n];
            int get_min_ans = 0, max_val = -1, get_max_ans = 0, min_val = -1;
            int prev_min_ans = -1, prev_min = -1, prev_max = -1, prev_max_ans = -1;
            Stack<int> stack_get_max_ans = new Stack<int>();
            Stack<int> stack_max = new Stack<int>();

            for (int j = 0; j < n; j += 1)
            {
                sp_a[j] = 0;
                disabled[j] = new List<int>();
            }
            for (int i = 0; i < q; i += 1)
            {
                string st = Console.ReadLine();
                if (st.StartsWith("RESET"))
                {
                    int num = Convert.ToInt32(st.Split()[1]) - 1;
                    sp_a[num] += 1;
                    disabled[num] = new List<int>();

                    int len = disabled[num].Count;
                    int ai = sp_a[num];
                    int result = ai * (m - len);

                    if (min_val == -1 || result < min_val)
                    {
                        prev_min_ans = get_min_ans;
                        prev_min = min_val;
                        get_min_ans = num;
                        min_val = result;
                    }

                    if (result == min_val && get_min_ans > num)
                    {
                        prev_min_ans = get_min_ans;
                        prev_min = min_val;
                        get_min_ans = num;
                    }

                    if (num == get_max_ans)
                    {
                        get_max_ans = prev_max_ans;
                        max_val = prev_max;
                    }

                } else if (st.StartsWith("DISABLE"))
                {
                    string[] st1 = st.Split();
                    int num1 = Convert.ToInt32(st1[1]) - 1, num2 = Convert.ToInt32(st1[2]) - 1;
                    if (disabled[num1].Count == 0 || !disabled[num1].Contains(num2))
                        disabled[num1].Add(num2);

                    int len = disabled[num1].Count;
                    int ai = sp_a[num1];
                    int result = ai * (m - len);
                    
                    if (max_val == -1 || result > max_val)
                    {
                        prev_max_ans = get_max_ans;
                        prev_max = max_val;
                        get_max_ans = num1;
                        max_val = result;
                    }
                    
                    if (result == max_val && get_max_ans > num1)
                    {
                        prev_max_ans = get_max_ans;
                        prev_max = max_val;
                        get_max_ans = num1;
                    }
                    
                    if (num1 == get_min_ans)
                    {
                        get_min_ans = prev_min_ans;
                        min_val = prev_min;
                    }
                }
                else if (st == "GETMAX")
                {
                    Console.WriteLine(get_max_ans + 1);
                } else if (st == "GETMIN")
                {
                    Console.WriteLine(get_min_ans + 1);
                }
                //Console.WriteLine($"{get_min_ans}, {min_val}, {get_max_ans}, {max_val}");
            }
            
        }
    }
}