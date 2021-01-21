using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int matrixRows = intput[0];
            int matrixCols = intput[1];
            string[,] matrix =new string[matrixRows, matrixCols];

            for (int row = 0; row < matrixRows; row++)
            {
                string[] matrixData = Console.ReadLine().Split();

                for (int col = 0; col < matrixCols; col++)
                {
                    matrix[row, col] = matrixData[col];
                }
            }

            string token = Console.ReadLine();

            while (token!="END")
            {


                string[] command = token.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if (command.Length!=5)
                {
                    Console.WriteLine("Invalid input!");
                    token = Console.ReadLine();
                    continue;
                }

                int rowOne = int.Parse(command[1]); 
                int colOne = int.Parse(command[2]); 
                int rowTwo = int.Parse(command[3]); 
                int colTwo = int.Parse(command[4]); 

                 bool isValid=CommandIsValid(matrix,rowOne,colOne,rowTwo,colTwo);
                if (isValid)
                {
                    string firstElement = matrix[rowOne, colOne];
                    string secondElement = matrix[rowTwo, colTwo];

                    matrix[rowTwo, colTwo] = firstElement;
                    matrix[rowOne, colOne] = secondElement;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                token = Console.ReadLine();
            }

        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
        }

        private static bool CommandIsValid(string[,] matrix, int rowOne, int colOne, int rowTwo, int colTwo)
        {
            return 
           rowOne >= 0 && rowOne < matrix.GetLength(0) && colOne >= 0 && colOne < matrix.GetLength(1)
           && rowTwo >= 0 && rowTwo < matrix.GetLength(0) && colTwo >= 0 && colTwo < matrix.GetLength(1);
        }
    }
}
