using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input!="END")
            {
                string number = input;

                Console.WriteLine(IfNumberIsPalindrome(number));

                input = Console.ReadLine();
            }
        }
        public static string IfNumberIsPalindrome(string number)
        {
            string reverse = String.Concat(number.Reverse());
            string result = string.Empty;
            if (reverse==number)
            {
                
                    result="true";
            }
            else
            {
                result = "false";
            }
            return result;
        
        }
    }
}
