using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();
            for (int i = 0; i < n; i++)
            {
                Box<double> currentBox = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(currentBox);
            }

            Box<double> comparebleBox = new Box<double>(double.Parse(Console.ReadLine()));

            int count = GetCompareCount(boxes,comparebleBox);
         

            Console.WriteLine(count);
        }

        private static int GetCompareCount(List<Box<double>> boxes, Box<double> comparebleBox)       
        {
            int counter = 0;
            foreach (var box in boxes)
            {
                int compare = box.CompareTo(comparebleBox);
                if (compare>0)
                {
                    counter++;
                }
            }

            return counter;          
        }
    }
}
