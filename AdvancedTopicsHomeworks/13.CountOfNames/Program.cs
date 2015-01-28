using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] names = input.Split(' ');
        Array.Sort(names);
        List<string> countNames = new List<string>();
        List<int> count = new List<int>();
        for (int i = 0; i < names.Length; i++)
        {
            if (!countNames.Contains(names[i]))
            {
                countNames.Add(names[i]);
                count.Add(0);
            }
        }
        for (int i = 0; i < countNames.Count; i++)
        {
            for (int x = 0; x < names.Length; x++)
            {
                if (countNames[i] == names[x])
                {
                    count[i]++;
                }
            }
        }
        int index = 0;
        foreach (var item in countNames)
        {
            Console.WriteLine(item + " -> " + count[index]);
            index++;
        }
    }
}

