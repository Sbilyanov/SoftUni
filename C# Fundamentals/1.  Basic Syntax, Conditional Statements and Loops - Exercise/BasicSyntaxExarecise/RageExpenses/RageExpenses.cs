using System;

namespace RageExpenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
          

                int gameCount = int.Parse(Console.ReadLine());
                double headsetPrice = double.Parse(Console.ReadLine());
                double mousePrice = double.Parse(Console.ReadLine());
                double keyboardPrice = double.Parse(Console.ReadLine());
                double displayPrice = double.Parse(Console.ReadLine());

            double total = (headsetPrice*(gameCount/2))+(mousePrice*(gameCount/3))+(keyboardPrice*(gameCount/6))+(displayPrice*(gameCount/12));
            Console.WriteLine($"Rage expenses: {total:F2} lv.");

        }
    }
}

