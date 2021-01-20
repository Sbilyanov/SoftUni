using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;

            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] matrixData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixData[col];

                }
            }
            int maxSum = int.MinValue;
            int maxRow = -1;
            int maxCol = -1;

            for (int row = 0; row < rows - n + 1; row++)
            {
                for (int col = 0; col < cols - n + 1; col++)
                {


                    int sum = 0;
                    for (int r = row; r < row + n; r++)
                    {
                        for (int c = col; c < col + n; c++)
                        {

                            sum += matrix[r, c];
                        }
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;

                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");


            for (int row = maxRow; row < maxRow + n; row++)
            {
                for (int col = maxCol; col < maxCol + n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}

