using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long count = 0;
        bool isPrime = false;
        for (long x = 1; x <= n; x++)
        {
            if (n <= 1)
            {
                isPrime = false;
                break;
            }
            if (n % x == 0 && x >= 1)
            {
                count++;
            }
            if (count > 2)
            {
                isPrime = false;
                break;
            }
            if (count == 2)
            {
                isPrime = true;
            }
        }
        Console.WriteLine(isPrime);
    }
}
