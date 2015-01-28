using System;

    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string space = " ";
            for (int i = 0; i < n; i++)
            {
                for (int x = 1; x <= n; x++)
                {
                    Console.Write(x + i);
                    if (x + i <= 9)
                    {
                        Console.Write(space);
                    }
                    if ((x + i) / 10 <= 9) // dali chisloto e m/y 10 i 99
                    {
                        Console.Write(space);
                    }
                    if ((x + i) / 100 <= 9) // dali chisloto e m/y 100 i 999
                    {
                        Console.Write(space);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }

