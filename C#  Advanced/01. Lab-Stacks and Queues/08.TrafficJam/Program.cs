using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsPass = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int count = 0;
            while (input!="end")
            {
                if (input=="green")
                {
                    for (int i = 0; i < numberOfCarsPass; i++)
                    {
                        if (cars.Count>0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            count++;

                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");

        }
    }
}
