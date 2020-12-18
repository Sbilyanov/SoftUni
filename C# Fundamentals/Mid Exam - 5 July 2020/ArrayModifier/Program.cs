using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            string input = Console.ReadLine();

            while (input!="end")
            {
                string[] command = input
                    .Split()
                    .ToArray();
               
                switch (command[0])
                {
                    case "swap":
                        int saveElement = numbers[int.Parse(command[1])];
                        numbers[int.Parse(command[1])]= numbers[int.Parse(command[2])];
                        numbers[int.Parse(command[2])]=saveElement;
                        break;
                    case "multiply":
                        int saveIndex = int.Parse(command[1]);
                        int result = numbers[int.Parse(command[1])] * numbers[int.Parse(command[2])];
                        numbers.Insert(saveIndex, result);
                    
                         numbers.RemoveAt(int.Parse(command[1])+1);
                    

                        break;
                    case "decrease":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] -= 1;
                        }
                  
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
