using System;

namespace PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int counter = 0;
            double exausPower = power * 0.50;


            while (power>=distance)
            {
                counter++;
                power -= distance;

                if (power==exausPower && exhaustionFactor!=0)
                {
                    power /= exhaustionFactor;

                }


            }
            Console.WriteLine(power);
            Console.WriteLine(counter);
        }
    }
}
