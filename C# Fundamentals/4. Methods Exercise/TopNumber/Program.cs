using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNumber(number);
        }

        private static void PrintTopNumber(int number)
        {
            for (int i = 0; i <=number; i++)
            {
                string currentNumber = i.ToString();
                bool isOdd = false;
                int sumOfDigits = 0;

                foreach (char digit in currentNumber)
                {
                    int currentDigit = (int)digit;

                    if ( currentDigit% 2 !=0)
                    {
                        isOdd = true;
                    }
                    sumOfDigits += currentDigit;
                }

                if (sumOfDigits%8==0 &&isOdd)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
