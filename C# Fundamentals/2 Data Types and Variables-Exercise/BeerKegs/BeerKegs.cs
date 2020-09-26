using System;

namespace BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int kegsNumber = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double maxVolume = 0;


            for (int i = 0; i < kegsNumber; i++)
            {
                string model = Console.ReadLine();
	            float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius,2) * height;

                if (volume>maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = model;
                }

            }
            Console.WriteLine(biggestKeg);

        }
    }
}
