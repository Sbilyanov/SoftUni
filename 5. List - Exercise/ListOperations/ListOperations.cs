using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class ListOperations
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                .Split()
                .ToArray();

            while (command[0].ToUpper()!="END")
            {
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "INSERT":
                        if (int.Parse(command[2]) <= numbers.Count && int.Parse(command[2]) >= 0)
                        {
                            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));

                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "REMOVE":
                        if (int.Parse(command[1]) <= numbers.Count && int.Parse(command[1]) >= 0)
                        {
                            numbers.RemoveAt(int.Parse(command[1]));

                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;
                    case "SHIFT":
                        if (command[1].ToUpper() == "LEFT") 
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                int firstIndex = numbers[0];
                                for (int j = 0; j < numbers.Count-1; j++)
                                {
                                    numbers[j] = numbers[j + 1];
                                }

                                numbers[numbers.Count - 1] = firstIndex;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                int lastIndex = numbers[numbers.Count - 1];
                                for (int j = numbers.Count - 1; j > 0; j--)
                                {
                                    numbers[j] = numbers[j - 1];

                                }
                                numbers[0] = lastIndex;

                            }
                        }
                                            
                        break;

                }

                command = Console.ReadLine()
                              .Split()
                              .ToArray();
            }
            Console.WriteLine(string.Join( ' ',numbers));
        }
    }
}
