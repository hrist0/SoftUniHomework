using System;

    class StudentCables
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int totalLength = 0;
            int count = 0;
            int cables = 0;
            int howMany = 0;
            for (int i = 0; i < input; i++)
            {
                int lenght = int.Parse(Console.ReadLine());
                string type = Console.ReadLine();
                if (type == "meters")
                {
                    lenght *= 100;
                }
                if (lenght < 20)
                {
                    lenght = 0;
                    count -= 1;
                }
                totalLength += lenght;
                count++;
            }
            totalLength = totalLength - ((count - 1) * 3);           
            howMany = totalLength / 504;
            howMany = howMany * 504;
            cables = totalLength - howMany;
            totalLength = totalLength / 504;
            Console.WriteLine(totalLength);
            Console.WriteLine(cables);
        }
    }

