using System;

namespace LowerOrUpper
{
    class LowerOrUpper
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            int input = (int)a;


            if ((input >= 60) && (input <= 90))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
