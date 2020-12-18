using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firtsNumber = int.Parse(Console.ReadLine());
               
            int secondNumber = int.Parse(Console.ReadLine());
             double fristFactorial =  GetFristFactorial(firtsNumber);
             double secondFactorial =  GetSeconFactorial(secondNumber);

            Console.WriteLine($"{fristFactorial/secondFactorial:f2}");
                 
        }

        private static double GetSeconFactorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }

        private static double GetFristFactorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
