using System;
using System.Linq;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                 .Split("\\", StringSplitOptions.RemoveEmptyEntries);
            var output = input[input.Length - 1].Split('.');

            Console.WriteLine($"File name: {output[0]}");
            Console.WriteLine($"File extension: {output[1]}");
        }
       
    }
}
