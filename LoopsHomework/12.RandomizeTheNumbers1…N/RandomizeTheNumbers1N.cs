using System;
using System.Collections.Generic;
using System.Linq;

    class RandomizeTheNumbers1N
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);               
            }
            Random rnd = new Random();
            bool check = true;
            while (check)
            {
                int print = rnd.Next(numbers.Min(), numbers.Max() + 1);
                for (int i = 0; i <= n - count; i++)
                {                  
                    if (print == numbers[i])
                    {
                        Console.Write(print + " ");
                        numbers.Remove(print);
                        count++;
                    }
                    if (count == n + 1)
                    {
                        check = false;
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }

