using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int dayCounter=0;
            int extractSpice = 0;
            int coumsumeSpice = 0;
            int spicesLeft = 0;
            for (int i = yield; i >=100; i-=10)
            {
                spicesLeft = i;
                dayCounter++;
           
                extractSpice += i;
                coumsumeSpice += 26;
            }
            if (spicesLeft>=26)
            {
                coumsumeSpice += 26;
            }
       
            Console.WriteLine(dayCounter);
            Console.WriteLine(extractSpice-coumsumeSpice);
        }
    }
}
