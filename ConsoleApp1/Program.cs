using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = Console.ReadLine();
            int error = -1;
            Stack stack = new Stack(st[0].ToString());
            for (int i = 0; i < st.Length; i += 1)
            {
                if (i == 0)
                    continue;
                string elem = st[i].ToString();
                if (elem == "{" || elem == "(" || elem == "[")
                {
                    stack.append(elem);
                }
                else
                {
                    StackItem res = stack.pop();
                    if (res is null || (res.value == "{" && elem != "}") || (res.value == "[" && elem != "]") || (res.value == "(" && elem != ")"))
                    {
                        error = i + 1;
                        break;
                    }
                }
            }
            if (error == -1)
            {
                Console.WriteLine("Success");
            } else
            {
                Console.WriteLine(error);
            }
        }
    }
}
