using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first =char.Parse(Console.ReadLine());
            char second =Convert.ToChar(Console.ReadLine());

            PrintCharsFromStartToEnd(first, second);

           
        }

        private static void PrintCharsFromStartToEnd(char first, char second)
        {

            char start;
            char end;

            if (first < second) 
            {
                start = first;
                end = second;
            }
            else
            {
                start = second;
                end = first;
            }
            for (int i = start + 1; i < end; i++)
            {

                Console.Write($"{(char)(i)} ");
            }
        }
    }
}
