using System;

    class CalculateNK
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            decimal factorialTwo = 1;
            decimal factorialResult = 0;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;             
            }
            for (int z = 1; z <= k; z++)
            {
                factorialTwo *= z;   
            }
            factorialResult = factorial / factorialTwo;
            Console.WriteLine("n!/k!= {0}", factorialResult);
        }
    }

