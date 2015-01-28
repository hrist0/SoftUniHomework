using System;

    class BinaryToDecimalNumber
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            char[] bits = binary.ToCharArray();
            long result = 0;
            for (int i = 1; i <= bits.Length; i++)
            {
                result += (bits[i - 1] - 48) * (long)Math.Pow(2 ,bits.Length - i);
            }
            Console.WriteLine(result);
        }
    }

