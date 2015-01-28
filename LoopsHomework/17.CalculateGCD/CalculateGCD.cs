using System;

    class CalculateGCD
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int gcd = 0;
            int count = 1;
            int biggest = 0;
            bool result = true;
            if (a > b)
            {
                biggest = a;
            }
            else
            {
                biggest = b;
            }
            while (result)
            {
                if (a % count == 0 && b % count == 0)
                {
                    gcd = count;
                }
                if (biggest + 1 == count) 
                {
                    break;
                }
                count++;
            }
            Console.WriteLine("GCD(a, b) = " + gcd);
        }
    }

