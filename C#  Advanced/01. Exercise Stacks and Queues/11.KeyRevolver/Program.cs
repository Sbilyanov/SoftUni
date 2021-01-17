using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulltetPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> bulletsStack = new Stack<int>(bulletsInput);

            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> locksQueue = new Queue<int>(locksInput);

            int valueIntelligence = int.Parse(Console.ReadLine());
            int bulletCount = 0;
            int currBarrelSize = barrelSize;

            while (bulletsStack.Any()&&locksQueue.Any())
            {
                bulletCount++;
   
                int currBullet = bulletsStack.Pop();
                int currLock = locksQueue.Peek();

                if (currBullet<=currLock)
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                currBarrelSize--;
                if (currBarrelSize == 0&&bulletsStack.Any())
                {
                    Console.WriteLine("Reloading!");
                    currBarrelSize = barrelSize;
                }

            }
            if (bulletsStack.Count>=0 &&locksQueue.Count==0)
            {
                int moneyEarned = valueIntelligence - (bulletCount * bulltetPrice);
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${moneyEarned}");
            }
            else if (locksQueue.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }

        }
    }
}
