using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = size[0];
            int m = size[1];

            string[,] matrix = new string[n, m];
            int currIndex = 0;
            int counter = 0;
            string matrixData = Console.ReadLine();
            int letterCounter = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (counter % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        letterCounter++;
                        if (letterCounter >= matrixData.Length)
                        {
                            letterCounter = 0;
                        }
                        matrix[row, col] = matrixData[letterCounter].ToString();

                        currIndex = col;
                       
                    }
                }
              
               // SoftUni
                else
                {
                    for (int revCol = currIndex; revCol >=0; revCol--)
                    {
                        letterCounter++;
                        if (letterCounter >= matrixData.Length)
                        {
                            letterCounter = 0;
                        }
                        matrix[row, revCol] = matrixData[letterCounter].ToString();
                        currIndex = revCol;
                       
                    }
                }
                counter++;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }


        }
    }
}
