using System;
using System.Collections.Generic;
using System.Collections;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, List<string>> forum = new Dictionary<string, List<string>>();
            Dictionary<int, string> messeges = new Dictionary<int, string>();
            int poryad_number = 1;
            for (int i = 0; i < n; i += 1)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    string tema = Console.ReadLine();
                    string mesege = Console.ReadLine();
                    forum[tema] = new List<string>();
                    forum[tema].Add(mesege);
                    messeges[poryad_number] = mesege;
                    poryad_number += 1;
                } else
                {
                    string mesege = Console.ReadLine();
                    string answer = messeges[num];
                    foreach (var key in forum.Keys)
                    {
                        if (forum[key].Contains(answer))
                            forum[key].Add(mesege);
                    }
                    messeges[poryad_number] = mesege;
                    poryad_number += 1;
                }
            }
            int mx_dl = 0;
            string ans = "";
            foreach (var key in forum.Keys)
            {
                if (forum[key].Count > mx_dl)
                {
                    mx_dl = forum[key].Count;
                    ans = key;
                }
            }
            Console.WriteLine(ans);
        }
    }
}