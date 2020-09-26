using System;

namespace SumOfChars
{
    class SumOfChars
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int result = 0;


            for (int i = 1; i <= lines; i++)
            {
                char input = char.Parse(Console.ReadLine());
                result += (int)input;
            }
            Console.WriteLine($"The sum equals: {result}");
        }
    }
}
