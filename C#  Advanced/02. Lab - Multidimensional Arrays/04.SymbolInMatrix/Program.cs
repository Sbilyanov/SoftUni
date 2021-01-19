using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row <matrix.GetLength(0) ; row++)
            {
                string charData = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = charData[col];
                }
            }

            string symbol = Console.ReadLine();
            string outut = String.Empty;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] == symbol[0])
                    {
                  
                        Console.WriteLine($"({r}, {c})");
                        return;
                    }
                }
            }
         
            
                Console.WriteLine($"{symbol} does not occur in the matrix");
            
        }
    }
}
