using System;
using System.Collections.Generic;

    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n + 1];
            int count = 1;
            int nextCount = 1;
            int maxCount = 1;
            int someIndex = 0;
            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
            }
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1] && nextCount >= maxCount)
                {      
                    someIndex = i + 1;
                    count++;
                    maxCount = count;
                }
                if (input[i] == input[i + 1])
                {
                    nextCount++;
                }
                else
                {
                    nextCount = 1;
                }
            }
            Console.WriteLine(maxCount);
            for (int i = someIndex - (count - 1); i < someIndex + 1; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }

