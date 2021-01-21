using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = size[0];
            int m = size[1];
            int playerRow = -1;
            int playerCol = -1;
            List<int[]> bunniesCoordinates = new List<int[]>();

            char[,] field = new char[n, m];

            for (int row = 0; row < n; row++)
            {
                char[] fieldData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < m; col++)
                {
                    field[row, col] = fieldData[col];
                    if (fieldData[col]=='P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                    if (fieldData[col]=='B')
                    {
                       bunniesCoordinates.Add(new int[]{row,col});
                    }
                }
            }
            char[] commands = Console.ReadLine().ToCharArray();
            bool isWon = false;
            bool isDead = false;

            foreach (char currCommand in commands)
            {

                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                if (currCommand == 'U')
                {
                    newPlayerRow--;
                }
                else if (currCommand == 'D')
                {
                    newPlayerRow++;
                }
                else if (currCommand == 'L')
                {
                    newPlayerCol--;
                }
                else if (currCommand == 'R')
                {
                    newPlayerCol++;
                }

                if (!CellIsValid(newPlayerCol, newPlayerRow, n, m))
                {
                    isWon = true;

                    field[playerRow, playerCol] = '.';                
                    SpreadBunnies(bunniesCoordinates, field);

                }
                else if (field[newPlayerRow, newPlayerCol] == '.')
                {
                    field[playerRow, playerCol] = '.';
                    field[newPlayerRow, newPlayerCol] = 'P';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    SpreadBunnies(bunniesCoordinates, field);

                    if (field[newPlayerRow, newPlayerCol]=='B')
                    {
                        isDead = true;
                    }

                }
                else if (field[newPlayerRow, newPlayerCol] == 'B')
                {
                    isDead = true;
                    field[playerRow, playerCol] = '.';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    SpreadBunnies(bunniesCoordinates, field);
                }

                if (isWon == true)
                {
                    PrintField(playerRow, playerCol, field);
                    Console.Write($"won: {playerRow} {playerCol}");
                    break;
                }
                if (isDead == true)
                {
                    PrintField(playerRow, playerCol, field);
                    Console.Write($"dead: {playerRow} {playerCol}");
                    break;
                }
            }
        }

        private static void PrintField(int playerRow, int playerCol, char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row,col]);
                }
                Console.WriteLine();
            }

        }

        private static void SpreadBunnies(List<int[]> bunniesCoordinates, char[,] field)
        {
            int fieldRows = field.GetLength(0);
            int fieldCols = field.GetLength(1);
            foreach (int[] bunny in bunniesCoordinates)
            {
                int row = bunny[0];
                int col = bunny[1];

                SpreadOneBunny(row - 1, col, field);
                SpreadOneBunny(row + 1, col, field);
                SpreadOneBunny(row, col+1, field);
                SpreadOneBunny(row, col-1, field);

            }
            for (int row = 0; row < fieldRows; row++)
            {
                for (int col = 0; col < fieldCols; col++)
                {
                    if (field[row,col] == 'B')
                    {
                        bunniesCoordinates.Add(new int[] { row, col });
                    }
                }
            }
        }

        private static void SpreadOneBunny(int row, int col, char[,] field)
        {
            int fieldRow = field.GetLength(0);
            int fieldCol = field.GetLength(1);
            if (CellIsValid(row, col, fieldRow, fieldCol))
            {
                field[row, col] = 'B';
            }
        }

        private static bool CellIsValid(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }
    }
}
