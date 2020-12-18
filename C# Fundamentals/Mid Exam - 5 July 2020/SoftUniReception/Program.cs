using System;
using System.Collections.Specialized;

namespace NationalCourt
{
    class NationalCourt
    {
        static void Main(string[] args)
        {
            int firstWorker = int.Parse(Console.ReadLine());
            int secondWorker = int.Parse(Console.ReadLine());
            int thirdtWorker = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            int count = 0;

            int totalWorkers = firstWorker + secondWorker + thirdtWorker;

            for (int i = 0; i < peopleCount; i += totalWorkers)
            {
                count++;
                if (count % 4 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Time needed: {count}h.");
        }
    }
}
