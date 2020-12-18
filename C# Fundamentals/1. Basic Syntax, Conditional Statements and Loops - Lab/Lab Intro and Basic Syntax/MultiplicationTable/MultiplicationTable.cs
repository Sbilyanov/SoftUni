using System;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int times = 1;
            while (times<=10)
            {
                Console.WriteLine($"{num} X {times} = {num*times}");
                times++;
            }
        }
    }
}
