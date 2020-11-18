using System;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {

                string output = new string(input.Reverse().ToArray());
                string result=$"{input} = {output}";
                
                Console.WriteLine($"{input} = {output}");
               

                input = Console.ReadLine();
            }

          
        }
    }
}
