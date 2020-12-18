using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            int result = AddCounter(input);
            Console.WriteLine(result);
            

        }

        private static int AddCounter( char[] input)
        {
            int counter = 0;
            string vowels = "EeUuIiOoAa";
            foreach (char index in input)
            {
                if (vowels.Contains(index))
                {
                    counter++;
                }
            }

            return counter;
          
        }
    }
}
