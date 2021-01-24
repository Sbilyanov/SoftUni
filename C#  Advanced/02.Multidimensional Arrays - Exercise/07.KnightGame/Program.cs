using System;
using System.Collections.Generic;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] chessBoard = new string[n, n];

            //Populate the board with knights
            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    chessBoard[row, col] = input[col].ToString();
                }
            }

            int knightsForRemove = 0;
            int strongestKnight = 0;
            int knightXposition = 0;
            int knightYposition = 0;

            while (true)
            {
                /*Check for possible moves and count knights which should be removed. The knights with
                * biggest amount of possibilities to hit another knight are the strongest, we should remove them
                 * first, until no such knights left. Then if there is no such knight we should stop and print the amount
                 * of knights for remove.
                */
                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {

                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        int hitCounter = 0;

                        if (chessBoard[row, col] == "K")
                        {
                            //Arrays of possible moves
                            int[] horizontalMoves = { 2, 1, -1, -2, -2, -1, 1, 2 };
                            int[] verticalMoves = { 1, 2, 2, 1, -1, -2, -2, -1 };

                            for (int move = 0; move < 8; move++)
                            {
                                //Position after move
                                int x = row + horizontalMoves[move];
                                int y = col + verticalMoves[move];

                                //Check if there is another Knight on the way and count the hit
                                if (x >= 0 && y >= 0 && x < n && y < n && chessBoard[x, y] == "K")
                                {
                                    hitCounter++;
                                }
                            }

                            //If there is stronger knight replace current data with his data 'cause we're searching for the strongest knight
                            if (hitCounter > strongestKnight)
                            {
                                strongestKnight = hitCounter;
                                hitCounter = 0;
                                knightXposition = row;
                                knightYposition = col;
                            }
                        }
                    }
                }

                //Remove the strongest knight with biggest amount of possibilities to hit another knight
                if (strongestKnight > 0)
                {
                    chessBoard[knightXposition, knightYposition] = "0";
                    strongestKnight = 0;
                    knightsForRemove++;
                }
                else
                {
                    //If there is no strongest knight 
                    break;
                }

            }

            Console.WriteLine(knightsForRemove);
        }

    }
}
 