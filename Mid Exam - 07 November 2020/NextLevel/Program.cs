using System;

namespace NextLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            double target = double.Parse(Console.ReadLine());
            int battlesCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= battlesCount; i++)
            {
                double currentBattle = double.Parse(Console.ReadLine());
                if (i % 3==0)
                {
                    currentBattle =currentBattle + (currentBattle * 0.15);
                }
                else if (i % 5 ==0)
                {
                    currentBattle = currentBattle - (currentBattle * 0.10);
                }
                else if (i% 15==0)
                {
                    currentBattle = currentBattle + (currentBattle * 0.05);
                }

                target -= currentBattle;
                if (target<=0)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }
            }
            Console.WriteLine($"Player was not able to collect the needed experience, {target:F2} more needed.");
        }
    }
}
