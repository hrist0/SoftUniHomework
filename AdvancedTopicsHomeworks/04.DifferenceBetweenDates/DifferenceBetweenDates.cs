using System;

    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            string[] formatFirst = firstDate.Split('.');
            string[] formatSecond = secondDate.Split('.');
            DateTime first = new DateTime(Convert.ToInt32(formatFirst[2]), Convert.ToInt32(formatFirst[1]), Convert.ToInt32(formatFirst[0]));
            DateTime second = new DateTime(Convert.ToInt32(formatSecond[2]), Convert.ToInt32(formatSecond[1]), Convert.ToInt32(formatSecond[0]));
            TimeSpan result = second - first;
            string[] printResult = Convert.ToString(result).Split(':', '.');
            Console.WriteLine(printResult[0]);
        }
    }

