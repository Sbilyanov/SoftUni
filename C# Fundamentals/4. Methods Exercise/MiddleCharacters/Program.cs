using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetTheMiddleCharecters(input));
        }

        private static string GetTheMiddleCharecters(string input)
        {
            string output = String.Empty;

            if (input.Length % 2 ==0)
            {
                int index = input.Length / 2;
                output = input.Substring(index-1, 2);
            }
            else
            {
                int indexOdd = input.Length / 2;
                output = input.Substring(indexOdd, 1);
            }
            return output;
        }
    }
}
