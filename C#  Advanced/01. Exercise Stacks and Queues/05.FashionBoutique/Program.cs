using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int racks = int.Parse(Console.ReadLine());
            Stack<int> stackOfClothes = new Stack<int>(input);
            int racksCount = 1;
            int currentRack = racks;


            while (stackOfClothes.Any())
            {
                int currentBox = stackOfClothes.Pop();

                currentRack-= currentBox;

                if (currentRack<0)
                {                   
                    racksCount++;
                    currentRack = racks-currentBox;
                }
            }
            Console.WriteLine(racksCount);
        }
    }
}
