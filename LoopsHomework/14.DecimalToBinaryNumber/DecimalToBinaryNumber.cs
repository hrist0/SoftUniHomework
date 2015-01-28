using System;

    class DecimalToBinaryNumber
    {
        static void Main(string[] args)
        {
            long numb = long.Parse(Console.ReadLine());
            string binary = "";
            bool realy = true;
            while (realy)
            {
                if (numb % 2 == 0)
                {
                    binary = "0" + binary;
                }
                else
                {
                    binary = "1" + binary;
                }
                numb /= 2;
                if (numb == 0)
                {
                    realy = false;
                }
            }
            Console.WriteLine(binary);
        }
    }

