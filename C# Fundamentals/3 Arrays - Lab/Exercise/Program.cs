using System;

namespace Exercise
{
    class Program
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
            int number = int.Parse(Console.ReadLine());

            if (number>0&&number<=day.Length)
            {
                Console.WriteLine(day[number-1]);
        
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }

    }
}
