using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] newB = input.Split(' ', '.');
        int count = 0;
        int[] newChars = new int[newB.Length + 1];
        for (int i = 0; i < newB.Length; i++)
        {
            char[] newLetters = newB[i].ToCharArray();
            for (int x = 0; x < newLetters.Length; x++)
            {
                count++;
            }
            newChars[i] = count;
            count = 0;
        }
        int max = 0;
        for (int i = 0; i < newChars.Length - 1; i++)
        {
            if (newChars[i] > newChars[i + 1] && newChars[i] > max)
            {
                max = newChars[i];
            }
            if (newChars[i] > newChars[i + 1] && newChars[i + 1] > max)
            {
                max = newChars[i];
            }
        }
        int index = Array.IndexOf(newChars, max);
        Console.WriteLine(newB[index]);
    }
}

