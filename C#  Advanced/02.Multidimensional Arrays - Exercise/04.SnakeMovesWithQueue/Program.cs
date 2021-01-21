using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SnakeMovesWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = size[0];
            int m = size[1];
            string input = Console.ReadLine();
            Queue<char> snakeMoves = new Queue<char>(input);
            
            int currIndex = 0;


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(snakeMoves.Dequeue());
                    currIndex++;
                    snakeMoves.Enqueue(input[j]);
                }
                snakeMoves = new Queue<char>(snakeMoves.Reverse());
                if (snakeMoves.Count>input.Length)
                {
                    for (int g = 0; g < input.Length; g++)
                    {
                        snakeMoves.Dequeue();
                    }

                }
                

                Console.WriteLine();
            }

        }
    }
}
