using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries );

            string str1 = text[0];
            string str2 = text[1];

            var longestWord = str1;
            var shortestWord = str2;


            if (str1.Length<str2.Length)
            {
                longestWord = str2;
                shortestWord = str1;
            }
             var total=CharacterMultiplier(longestWord, shortestWord);
            Console.WriteLine(total);
        }

        private static int CharacterMultiplier(string longestWord, string shortestWord)
        {
            var sum = 0;
            for (int i = 0; i < shortestWord.Length; i++)
            {
                var multiply = shortestWord[i] * longestWord[i];
                sum += multiply;
            }

            for (int i = shortestWord.Length; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
            }

            return sum;
        }
    }
}
