using System;
using System.Linq;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double[] numb = new double[input];
            for (int i = 0; i < input; i++)
            {
                numb[i] = double.Parse(Console.ReadLine());                
            }
            Console.WriteLine("min = {0}", numb.Min());
            Console.WriteLine("max = {0}", numb.Max());
            Console.WriteLine("sum = {0}", numb.Sum());
            double avg = numb.Average();
            Console.WriteLine("avg = {0:f2}", Math.Round(avg, 2));
        }
    }

