using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> filtter = text => Char.IsUpper(text[0]);

            string[] text = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Where(filtter).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,text));
        }
    }
}
