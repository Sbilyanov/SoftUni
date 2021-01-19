using System;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().Split();
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row,col] = int.Parse(input[col]);
                }

            }
            var command = Console.ReadLine().Split();

            while (command[0]!="END")
            {
                int currRow = int.Parse(command[1]);
                int currCol = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (currRow >= 0 && currCol >= 0 && currRow < n && currCol < n)
                {
                    switch (command[0])
                    {
                        case "Add":
                            matrix[currRow,currCol] += value;
                            break;
                        case "Subtract":
                            matrix[currRow,currCol] -= value;
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                command = Console.ReadLine().Split();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
