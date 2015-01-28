using System;
using System.Globalization;

    class ExamSchedule
    {
        static void Main(string[] args)
        {
            string hour = Console.ReadLine();
            string minutes = Console.ReadLine();
            string part = Console.ReadLine();
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            string time = hour + ":" + string.Format(minutes.PadLeft(2, '0')) + ":" + part;
            DateTime startTime = DateTime.ParseExact(time, "h:mm:tt", CultureInfo.InvariantCulture);
            DateTime endTime = startTime.AddHours(examHours).AddMinutes(examMinutes);
            Console.WriteLine(endTime.ToString("hh:mm:tt"));
        }
    }

