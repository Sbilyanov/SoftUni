using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.GenericCountMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();
            for (int i = 0; i < n; i++)
            {
                Box<string> currentBox = new Box<string>(Console.ReadLine());
                boxes.Add(currentBox);
            }

            Box<string> comperableBox = new Box<string>(Console.ReadLine());

            int count= CompareBoxes(boxes, comperableBox);

           

            Console.WriteLine(count);
        }

        private static int CompareBoxes(List<Box<string>> boxes, Box<string> comperableBox)
                    {
            int count = 0;

            foreach (var box in boxes)
            {
              
                int result = box.Value.CompareTo(comperableBox.Value);
                if (result>0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
