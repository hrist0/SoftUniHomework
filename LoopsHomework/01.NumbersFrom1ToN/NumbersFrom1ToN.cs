using System;

    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < input; i++)
            {
                count++;
                Console.Write(count + " ");
            }
            Console.WriteLine();
            Console.WriteLine("HI!!!");
        }

    }

