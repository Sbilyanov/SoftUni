using System;
using System.Collections.Generic;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];

                }
            }

           int removedKnights = 0;

            while (true)
            {
                int maxAttackedKnighs = 0;
                int knightRow = -1;
                int knightCol = -1;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char symbol = matrix[row, col];

                        if (symbol != 'K')
                        {
                            continue;
                        }
                        int count = GetCountOfAttackedKnight(matrix, row, col);
                     
                        if (count > maxAttackedKnighs)
                        {
                            maxAttackedKnighs = count;
                            knightRow = row;
                            knightCol = col;
                        }               
                    }
                }
                if (maxAttackedKnighs == 0)
                {
                    break;
                }
                matrix[knightRow, knightCol] = '0';
                removedKnights++;
            }


            Console.WriteLine(removedKnights);
        }


        private static int GetCountOfAttackedKnight(char[,] matrix, int row, int col)
        {
            int count = 0;
            if (ContainsKnights(matrix, row -2, col -1))
            {
                count++;
            }
            if (ContainsKnights(matrix, row -2, col + 1))
            {
                count++;
            }
            if (ContainsKnights(matrix, row - 1, col - 2))
            {
                count++;
            }
            if (ContainsKnights(matrix, row - 1, col + 2))
            {
                count++;
            }
            if (ContainsKnights(matrix, row + 1, col -2))
            {
                count++;
            }
            if (ContainsKnights(matrix, row + 1, col + 2))
            {
                count++;
            }
            if (ContainsKnights(matrix, row + 2, col - 1))
            {
                count++;
            }
            if (ContainsKnights(matrix, row - 2, col - 1))
            {
                count++;
            }

            return count;

        }

        private static bool ContainsKnights(char[,] matrix, int row, int col)
        {
            if (!CellIsValid(row, col, matrix.GetLength(0)))
            {
                return false;
            }
            return matrix[row, col] == 'K';
        }

        private static bool CellIsValid(int row, int col, int n)
        {
            return row >= 0 && row < n && col >= 0 && col < n;
        }

    }
}
 