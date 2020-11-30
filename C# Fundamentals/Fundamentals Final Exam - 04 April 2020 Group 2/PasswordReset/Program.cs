using System;
using System.Linq;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = Console.ReadLine();

            while (input!="Done")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                

                switch (command)
                {
                    case "TakeOdd":

                        password = String.Concat(password.Where((c, i) => i % 2 != 0));
                   
                        Console.WriteLine(password);          
                        break;

                    case "Cut":
                        password = password.Remove(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        Console.WriteLine(password);
                        break;
                 
                    case "Substitute":
                        if (password.Contains(tokens[1]))
                        {
                            password = password.Replace(tokens[1], tokens[2]);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;
                   
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
