using System;

    class FibbonaciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int x = 0;
            int z = 1;
            int[] fibonacci = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    z = x + z;
                    fibonacci[i] = z;
                }
                else
                {
                    x = z + x;
                    fibonacci[i] = x;
                }
            }
            Console.WriteLine("Fib(n) = " + fibonacci[n]);
         }
    }

