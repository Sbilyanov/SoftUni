using System;

namespace CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {

            //1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
            int centuries = int.Parse(Console.ReadLine());
            int yaers = centuries * 100;
            int days = (int)(yaers * 365.2422);
            long hours = 24 * days;
            long minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {yaers} years = {days} days = {hours} hours = {minutes} minutes");



        }
    }
}
