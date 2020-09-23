using System;

namespace SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int biggest = Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber);
            int smallest = Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);
            int middle = (firstNumber + secondNumber + thirdNumber) - (biggest + smallest);

            Console.WriteLine(biggest);
            Console.WriteLine(middle);
            Console.WriteLine(smallest);
        }
    }
}
