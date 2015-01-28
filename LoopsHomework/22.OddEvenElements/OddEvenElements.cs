using System;
using System.Collections.Generic;
using System.Linq;

class OddEvenElements
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] newNumb = input.Split(' ');
        List<double> oddSum = new List<double>();
        List<double> evenSum = new List<double>();
        for (int i = 0; i < newNumb.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddSum.Add(Convert.ToDouble(newNumb[i]));
            }
            else
            {
                evenSum.Add(Convert.ToDouble(newNumb[i]));
            }
        }
        if (input.Length > 1)
        {
            Console.WriteLine("OddSum = {0}, OddMin = {1}, OddMax = {2}, EvenSum = {3}, EvenMin = {4}, EvenMax = {5}", oddSum.Sum(), oddSum.Min(), oddSum.Max(), evenSum.Sum(), evenSum.Min(), evenSum.Max());
        }
        else
        {
            Console.WriteLine("OddSum = {0}, OddMin = {1}, OddMax = {2}, EvenSum = No, EvenMin = No, EvenMax = No", oddSum.Sum(), oddSum.Min(), oddSum.Max());
        }
    }
}

