using System;

    class RandomNumberInGivenRange
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = min; i <= max; i++)
            {
                Console.Write(rnd.Next(min, max + 1) + " ");
            }
        }
    }

