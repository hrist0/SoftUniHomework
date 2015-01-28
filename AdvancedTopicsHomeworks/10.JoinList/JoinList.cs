using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string inputOne = Console.ReadLine();
        string inputTwo = Console.ReadLine();
        List<int> sorted = new List<int>();
        string[] lineOne = inputOne.Split(' ');
        string[] lineTwo = inputTwo.Split(' ');
        int count = 0;
        for (int i = 0; i < lineOne.Length; i++)
        {
            if (!sorted.Contains(Convert.ToInt32(lineOne[i])))
            {
                sorted.Add(Convert.ToInt32(lineOne[i]));
                count++;
            }
        }
        for (int i = 0; i < lineTwo.Length; i++)
        {

            if (!sorted.Contains(Convert.ToInt32(lineTwo[i])))
            {
                sorted.Add(Convert.ToInt32(lineTwo[i]));
                count++;
            }
        }
        sorted.Sort();
        foreach (int item in sorted)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

