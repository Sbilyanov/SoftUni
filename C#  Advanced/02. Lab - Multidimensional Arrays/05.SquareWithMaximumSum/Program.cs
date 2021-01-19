using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = 2;
          
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];
            int maxSum = int.MinValue;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] dataMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = dataMatrix[c];

                }
            }
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < rows - size + 1; row++)
            {
                for (int col = 0; col < cols - size + 1; col++)
                {


                    int subMatrixSum = 0;
                    for (int subRow = row; subRow < row + size; subRow++)
                    {
                        for (int subCol = col; subCol < col+size; subCol++)
                        {

                            subMatrixSum += matrix[subRow, subCol];
                        }
                    }
                    if (subMatrixSum > maxSum)
                    {
                        maxSum = subMatrixSum;
                        maxRow = row;
                        maxCol = col;

                    }
                }
            }


            for (int row = maxRow; row < maxRow + size; row++)
            {
                for (int col = maxCol; col < maxCol + size; col++)
                {
                  Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);


        }
    }
}