using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.GenericSwapMethodIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> boxes = new List<Box<int>>();
            for (int i = 0; i < n; i++)
            {
                Box<int> currentBox = new Box<int>(int.Parse(Console.ReadLine()));
                boxes.Add(currentBox);
            }
            int[] indexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            IndexSwap(boxes, indexes[0], indexes[1]);

            Console.WriteLine(string.Join(Environment.NewLine, boxes));

        }

        private static void IndexSwap<T>(List<Box<T>> boxes, int firstIndex, int secondIndex)
        {
            Box<T> temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;
        }
    }
}
