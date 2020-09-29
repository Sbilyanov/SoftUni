using System;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {


            string[] day = new string[]
            {
               "Monday",
               "Tuesday",
               "Wednesday",
                "Thursday",
                 "Friday",
                "Saturday",
                  "Sunday"
            };
            int dayNum = int.Parse(Console.ReadLine());

            if (dayNum < 1 || dayNum > day.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(day[dayNum-1]);
            }
        }
    }
}
