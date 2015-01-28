using System;

class Arrow
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        string sharp = "#";
        int count = 1;
        string topDot = new string('.', input / 2);
        string sharpTop = new string('#', input);
        Console.WriteLine(topDot + sharpTop + topDot);
        for (int i = 0; i < input - 2; i++)
        {
            string newDot = new string('.', input / 2);
            string midDot = new string('.', input - 2);
            Console.WriteLine(newDot + sharp + midDot + sharp + newDot);
        }
        string midSharp = new string('#', (input / 2) + 1);
        string dot = new string('.', input - 2);
        Console.WriteLine(midSharp + dot + midSharp);
        for (int i = 0; i < input - 2; i++)
        {
            string botDot = new string('.', count);
            string dotTwo = new string('.', (input * 2) - (count * 2) - 3);
            Console.WriteLine(botDot + sharp + dotTwo + sharp + botDot);
            count++;
        }
        string bottom = new string('.', input - 1);
        Console.WriteLine(bottom + sharp + bottom);
    }
}

