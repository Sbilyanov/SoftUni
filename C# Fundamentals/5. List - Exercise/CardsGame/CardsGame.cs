using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class CardsGame
    {
        static void Main(string[] args)
        {
            List<int> fristPlayer = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            while (fristPlayer.Count != 0 && secondPlayer.Count != 0)
            {

                if (fristPlayer[0] > secondPlayer[0])
                {
                    fristPlayer.Add(fristPlayer[0]);
                    fristPlayer.Add(secondPlayer[0]);
                }
                else if (secondPlayer[0] > fristPlayer[0])
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(fristPlayer[0]);
                }

                fristPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);

            }
            if (fristPlayer.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {fristPlayer.Sum()}");
            }
        }
    }
}
