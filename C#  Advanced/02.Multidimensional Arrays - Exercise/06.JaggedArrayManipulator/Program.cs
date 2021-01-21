using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[n][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                double[] jaggedArrayData = Console.ReadLine().Split().Select(double.Parse).ToArray();
                jaggedArray[row] = jaggedArrayData;
            }
            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                double[] firstArray = jaggedArray[row];
                double[] secondArray = jaggedArray[row + 1];

                if (firstArray.Length == secondArray.Length)
                {
                    jaggedArray[row] = firstArray.Select(e => e * 2).ToArray();
                    jaggedArray[row + 1] = secondArray.Select(e => e * 2).ToArray();
                }
                else
                {
                    jaggedArray[row] = firstArray.Select(e => e / 2).ToArray();
                    jaggedArray[row + 1] = secondArray.Select(e => e / 2).ToArray();
                }

            }

            string command = Console.ReadLine();

            while (command!="End")
            {
                string[] commandArray = command.Split();

                int indexRow = int.Parse(commandArray[1]);
                int indexCol = int.Parse(commandArray[2]);
                int value = int.Parse(commandArray[3]);

                bool commanIsValid = indexRow >= 0 && indexRow < jaggedArray.Length 
                                  && indexCol >= 0 && indexCol < jaggedArray[indexRow].Length;
                if (!commanIsValid)
                {
                    command = Console.ReadLine();
                    continue;
                }

                switch (commandArray[0])
                {
                    case "Add":

                        jaggedArray[indexRow][indexCol] += value;
                       break;
                    case "Subtract":

                        jaggedArray[indexRow][indexCol] -= value;
                        break;
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join(" ",jaggedArray[row]));
            }
        }
    }
}
