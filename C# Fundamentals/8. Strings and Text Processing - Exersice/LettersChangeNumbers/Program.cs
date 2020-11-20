using System;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double result = 0;


            for (int i = 0; i < input.Length; i++)
            {
                string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                string current = input[i];
                char firstLetter = current[0];
                char lastLetter = current[current.Length - 1];

                double number = double.Parse(current.Substring(1, current.Length - 2));

                int firstletterIndex = 1 + alphabet.IndexOf(char.ToUpper(firstLetter));
                int lastletterIndex = 1 + alphabet.IndexOf(char.ToUpper(lastLetter));



                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    number = number / firstletterIndex;

                }
                else
                {
                    number = number * firstletterIndex;
                }



                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    number = number - lastletterIndex;
                }
                else
                {
                    number = number + lastletterIndex;
                }

                result += number;
            }
            Console.WriteLine($"{result:f2}");

        }
    }
}
