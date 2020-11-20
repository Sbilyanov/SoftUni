using System;
using System.Linq;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            foreach (var ch in input)
            {
               char current= (char)(ch + 3);
                
                Console.Write(current);
            }


            
        }
    }
}
