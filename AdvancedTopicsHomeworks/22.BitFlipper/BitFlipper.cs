using System;

class BitFlipper
{
    static void Main(string[] args)
    {
        ulong input = ulong.Parse(Console.ReadLine());
        ulong check = 0;
        ulong mask = (ulong)7 << 61;
        //string resultCheck = "";
        while (true)
        {
            check = input & mask;
            if (check == mask || check == 0)
            {
                //resultCheck = Convert.ToString((long)input, 2).PadLeft(64, '0');
                //Console.WriteLine(resultCheck);
                input = input ^ mask;
                mask = mask >> 3;
                //resultCheck = Convert.ToString((long)input, 2).PadLeft(64, '0');
                //Console.WriteLine(resultCheck);
            }
            else
            {
                mask = mask >> 1;
            }
            if (mask <= 7)
            {
                break;
            }
        }
        Console.WriteLine(input);
    }
}

