using System;

namespace AddАndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int frist = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int thrid = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtract(frist, second) - thrid);
        }

        private static int Subtract(int frist, int second)
        {
            int sum = frist + second;
            return sum;
        }
    }
}
