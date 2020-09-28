using System;

namespace RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= input; i++)
            {
               int total = 0;
               int number = i;
                while (number > 0)
                {
                    total += number % 10;
                    number = number / 10;
                }
                 bool isSpecialNum = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{i} -> {isSpecialNum}");
           
            }

        }
    }
}
