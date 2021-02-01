using System;

namespace _05.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int result=DateModifier.GetDateModifier(firstDate, secondDate);

            Console.WriteLine(Math.Abs(result));

        }
    }
}
