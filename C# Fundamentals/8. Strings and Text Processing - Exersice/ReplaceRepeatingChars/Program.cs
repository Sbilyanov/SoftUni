using System;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i]!=input[i+1])
                {
                    sb.Append(input[i]);
                }

            }
            sb.Append(input[input.Length - 1]);
            Console.WriteLine(sb);

        }
    }
}
