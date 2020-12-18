using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int battles = 0;
            int win = 0;
            bool isWon = true;

            while (input?.ToUpper() != "END OF BATTLE")
            {
                battles++;
                int distance = int.Parse(input);

                if (distance>energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {win} won battles and {energy} energy");
                    isWon = false;
                    break;
                }
                energy -= distance;
                win++;
                if (win % 3 == 0) 
                {
                    energy += win;

                }

                input = Console.ReadLine();
            }
            if (isWon)
            {
                Console.WriteLine($"Won battles: {win}. Energy left: {energy}");
            }
            
        }
    }
}
