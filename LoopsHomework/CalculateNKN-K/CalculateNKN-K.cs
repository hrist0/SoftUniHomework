using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int minus = n - k;
            decimal factorial = 1;
            decimal factorialTwo = 1;
            decimal factorialThree = 1;
            decimal result = 0;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                factorialTwo *= i;
            }
            for (int i = 1; i <= minus; i++)
            {
                factorialThree *= i;
            }
            result = factorial / (factorialTwo * factorialThree);
            Console.WriteLine("n! / (k! * (n-k)!) = {0}", result);
        }
    }

