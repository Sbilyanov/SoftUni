using System;
using System.Linq;

namespace _01._Problem
{
    class Problem1
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            string input = Console.ReadLine();

            while (input!= "Sign up")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                
                switch (command[0])
                {
                    case "Case":
                        string size = command[1];
                        if (size == "lower")
                        {
                            userName = userName.ToLower();
                        }
                        else
                        {
                            userName = userName.ToUpper();
                        }
                        Console.WriteLine(userName);
                        break;
                    case "Reverse":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        if (startIndex >= 0 && startIndex < userName.Length
                            && endIndex >= 0 && endIndex < userName.Length)
                        {
                            string reverse = String.Concat(userName.Substring(startIndex, endIndex).Reverse());
                            Console.WriteLine(reverse);
                        }
                        break;
                    case "Cut":
                        string subString = command[1];

                        if (userName.Contains(subString))
                        { 
                            int sub = userName.IndexOf(subString);
                            string cut = userName.Substring(sub, subString.Length);
                            userName = userName.Replace(cut, "");
                            Console.WriteLine(userName);
                        }
                        else
                        {
                            Console.WriteLine($"The word {userName} doesn't contain {subString}");
                        }
                        break;
                    case "Replace":
                        char ch =  command[1].ToCharArray()[0];
                        userName = userName.Replace(ch, '*');
                        Console.WriteLine(userName);
                        break;
                    case "Check":
                        char validChar = command[1].ToCharArray()[0];
                        if (userName.Contains(validChar))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {validChar}");
                        }
                        break;
                    
                }

                input = Console.ReadLine();
            }
        }
    }
}
