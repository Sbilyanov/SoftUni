using System;
using System.Numerics;

namespace SnowBalls
{
    class SnowBalls
    {
        static void Main(string[] args)
        {
  
                int snowballsCount = int.Parse(Console.ReadLine());
            BigInteger MaxSnowballValue = 0;
            int snowballSnow = 0;  
            int snowballTime = 0;
            int snowballQuality = 0;



            for (int i = 0; i < snowballsCount; i++)
            {
                int CurrentSnowballSnow = int.Parse(Console.ReadLine());
                int CurrentSnowballTime = int.Parse(Console.ReadLine());
                int CurrentSnowballQuality = int.Parse(Console.ReadLine());
               BigInteger snowballValue = BigInteger.Pow((CurrentSnowballSnow / CurrentSnowballTime),CurrentSnowballQuality);
                if (snowballValue>=MaxSnowballValue)
                {
                    MaxSnowballValue = snowballValue;
                    snowballSnow = CurrentSnowballSnow;
                    snowballTime = CurrentSnowballTime;
                    snowballQuality = CurrentSnowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {MaxSnowballValue} ({snowballQuality})");

        }
    }
}
