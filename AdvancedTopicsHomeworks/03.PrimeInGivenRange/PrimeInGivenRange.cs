using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        long y = 0;
        for (long x = startNum; x <= endNum; x++)
        {
            if (f % x == 0)
            {
                y++;
            }
        }
        if (y == 2)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
