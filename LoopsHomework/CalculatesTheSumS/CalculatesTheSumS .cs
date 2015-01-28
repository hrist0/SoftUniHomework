using System;

    class CalculatesTheSumS
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            double factorial = 1;
            double count = 1;
            double S = 0;
            for (double i = 1; i <= n; i++)
            {
                factorial *= i;
                count += (factorial / (long)Math.Pow(x, i));
            }
            Console.WriteLine("S = {0:f5}", count);
        }
    }

