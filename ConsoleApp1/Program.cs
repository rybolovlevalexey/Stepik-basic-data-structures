using System;
using System.Collections.Generic;
using System.Collections;


namespace ConsoleApp1
{
    class Program
    {
        static T Max<T>(params T[] args) where T: IComparable
        {
            if (args.Length == 0)
                return default(T);
            var ans = args[0];
            for (int i = 1; i < args.Length; i += 1)
            {
                if (ans.CompareTo(args[i]) == -1)
                    ans = args[i];
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Max(new int[0]));
            Console.WriteLine(Max(new[] { 3 }));
            Console.WriteLine(Max(new[] { 3, 1, 2 }));
            Console.WriteLine(Max(new[] { "A", "B", "C" }));
        }
    }
	public class LimitedSizeStack<T>
	{
		private int count = 0;
		private int? stack_limit = null;
		private LinkedList<T> stack_data;
		public LimitedSizeStack(int undoLimit)
		{
			stack_limit = undoLimit;
			stack_data = new LinkedList<T>();
		}

		public void Push(T item)
		{
			if (count == stack_limit)
			{
				stack_data.RemoveFirst();
				stack_data.AddLast(item);
			}
			else
			{
				stack_data.AddLast(item);
				count += 1;
			}
		}

		public T Pop()
		{
			if (count > 0)
			{
				count -= 1;
			}
			return stack_data.Last.Value;
		}
		public int Count { get { return count; } }
	}
}