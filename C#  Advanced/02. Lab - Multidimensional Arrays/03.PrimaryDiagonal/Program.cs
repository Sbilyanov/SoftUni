using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[,] matrix = new int[n, n];

            int diagonalSum = 0;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] matrixData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = matrixData[c];
                    if (r == c)
                    {
                        diagonalSum += matrixData[c];
                    }
                }

            }
            Console.WriteLine(diagonalSum);


        }
    }
}
