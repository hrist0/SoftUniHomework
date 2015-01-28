using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] letters = input.ToCharArray();
        List<char> chars = new List<char>();
        List<int> countChars = new List<int>();
        for (int i = 0; i < letters.Length; i++)
        {

            if (!chars.Contains(letters[i]) && letters[i] != ' ')
            {
                chars.Add(letters[i]);
            }
            if (chars.Contains(letters[i]))
            {
                countChars.Add(0);
            }
        }

        for (int i = 0; i < chars.Count; i++)
        {
            for (int x = 0; x < letters.Length; x++)
            {
                if (chars[i] == letters[x])
                {
                    countChars[i]++;
                }
            }
        }
        int count = 0;
        List<string> sorted = new List<string>();
        foreach (var item in chars)
        {
            sorted.Add(Convert.ToChar(item) + " -> " + countChars[count]);
            count++;
        }
        sorted.Sort();
        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }
    }
}

