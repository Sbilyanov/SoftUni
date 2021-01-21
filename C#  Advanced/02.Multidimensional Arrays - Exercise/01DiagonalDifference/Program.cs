using System;
using System.Linq;

namespace _01DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] marix = new int[n,n];

            for (int row = 0; row < marix.GetLength(0); row++)
            {
                int[] dataMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < marix.GetLength(1); col++)
                {
                    marix[row,col]=dataMatrix[col];
                }
            }

            int firstDiagonalSum = 0;
            int SecondtDiagonalSum = 0;
          

            for (int i = 0; i < n; i++)
            {
                firstDiagonalSum += marix[i, i];           
                SecondtDiagonalSum += marix[i,n-i-1];
            }
            Console.WriteLine(Math.Abs(firstDiagonalSum-SecondtDiagonalSum));
        }
    }


    CellIsValid(row + 1, col + 2, n);
    CellIsValid(row + 1, col - 2, n);
    CellIsValid(row - 1, col + 2, n);
    CellIsValid(row - 1, col - 2, n);
    CellIsValid(row + 2, col + 1, n);
    CellIsValid(row + 2, col - 1, n);
    CellIsValid(row - 2, col + 1, n);
    CellIsValid(row - 2, col - 1, n);
}
