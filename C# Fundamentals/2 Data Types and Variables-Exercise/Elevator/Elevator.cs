using System;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int result = (int)Math.Ceiling((double)peopleNumber / capacity);

            Console.WriteLine(result);

        }
    }
}
