using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());

            Printtext(text, times);
        }

        private static void Printtext(string str, int num)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                result.Append(str);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
