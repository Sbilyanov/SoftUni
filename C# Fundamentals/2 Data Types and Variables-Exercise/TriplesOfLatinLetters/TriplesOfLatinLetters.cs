using System;

namespace TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (int i = 0; i <number; i++)
            {
                for (int j = 0; j <number; j++)
                {
                    for (int k = 0; k <number; k++)
                    {
                           Console.WriteLine($"{(char)('a'+i)}{(char)('a'+j)}{(char)('a'+k)}");
                    }
                }
            }
        }
    }
}
