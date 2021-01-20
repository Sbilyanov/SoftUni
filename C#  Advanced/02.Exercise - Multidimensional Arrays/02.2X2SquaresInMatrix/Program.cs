using System;
using System.Linq;

namespace _02._2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            string[,] matrix = new string[rows, cols];
            for (int r = 0; r < rows; r++)
            {
               string[] dataMatrix = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[r, col] = dataMatrix[col];
                }
            }

            int squareCounter = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (matrix[row,col]==matrix[row,col+1] 
                        && matrix[row,col]==matrix[row+1,col]
                        && matrix[row,col]==matrix[row+1,col+1])
                    {
                        squareCounter++;
                    }
                }
            }
            Console.WriteLine(squareCounter);
           
        }
    }
}
