using System;

    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());          
            decimal factorial = 1;
            decimal factorialTwo = 1;
            decimal factorialThree = 1;
            int nTwo = n * 2;
            int nThree = n + 1;
            decimal catalanN = 0;
            for (int i = 1; i <= nTwo; i++)
            {
                factorial *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                factorialTwo *= i;
            }
            for (int i = 1; i <= nThree; i++)
            {
                factorialThree *= i;
            }
            catalanN = factorial / (factorialThree * factorialTwo);
            Console.WriteLine("Catalan(n) = {0}", catalanN);
        }
    }

