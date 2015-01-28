using System;

    class HexadecimalToDecimalNumber
    {
        static void Main(string[] args)
        {
            string hexa = Console.ReadLine();
            char[] chars = hexa.ToCharArray();
            long result = 0;
            for (int i = 0; i < hexa.Length; i++)
            {
                switch (chars[i])
                {
                    case 'A':
                        result += 10 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                }
            }
        }
    }

