using System;

namespace _02.GenericBoxOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
              Box<int> numbers = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(numbers);
            }
           
        }
    }
}
