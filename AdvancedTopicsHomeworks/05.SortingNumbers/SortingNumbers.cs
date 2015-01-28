using System;
using System.Collections.Generic;
using System.Linq;

    class SortingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> newNumb = new List<int>();
            for (int i = 0; i < n; i++)
            {
                newNumb.Add(int.Parse(Console.ReadLine()));
            }
            newNumb.Sort();
            for (int i = 0; i < n; i++)
            {
            Console.WriteLine(newNumb[i]);                
            }
            Console.WriteLine();
        }
    }

