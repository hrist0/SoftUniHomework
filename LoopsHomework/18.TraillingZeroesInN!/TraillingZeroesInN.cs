using System;
using System.Numerics;

    class TraillingZeroesInN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            for (int i = 0; i < factorial; i++)
            {
                if (factorial % 10 == 0)
                {
                    factorial /= 10;
                    count++;
                }
                else 
                {
                    break;
                }
            }
            Console.WriteLine("trailing zeroes of n! " + count);
        }
    }

