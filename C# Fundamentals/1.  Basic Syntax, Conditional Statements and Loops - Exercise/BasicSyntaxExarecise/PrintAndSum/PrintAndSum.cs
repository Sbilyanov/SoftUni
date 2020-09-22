using System;

namespace PrintAndSum
{
    class PrintAndSum
    {
        static void Main(string[] args)
        {
            int fristNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = fristNumber; i <= secondNumber; i++)
            {
                Console.Write(i + " ");
                sum = sum + i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
