using System;

namespace WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int flowolLines = int.Parse(Console.ReadLine());
            int maxCapacity = 0;
          

            for (int i = 0; i < flowolLines; i++)
            {
                 int litres = int.Parse(Console.ReadLine());
                maxCapacity+=litres;
                if (maxCapacity>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    maxCapacity -= litres;
                }

            }
            Console.WriteLine(maxCapacity);
           


        }
    }
}
