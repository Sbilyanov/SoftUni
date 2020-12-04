using System;
using System.Linq;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = Console.ReadLine();

            string input = Console.ReadLine();

            while (input!="Decode")
            {
                string[] command = input.Split('|', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Move":
                        int n = int.Parse(command[1]);
                        if (n <= code.Length)
                        {
                            string element = (code.Substring(0, n));
                            code = code.Remove(0, n);
                            code = code+=element;
                        }
                        break;

                    case "Insert":

                        int index = int.Parse(command[1]);
                        string value = command[2];
                        if (index >= 0 && index <= code.Length)
                        {
                            code = code.Insert(index, value);
                        }
                        break;
                    case "ChangeAll":
                        string substring = command[1];
                        string replacment = command[2];
                        if (code.Contains(substring))
                        { 
                            code = code.Replace(substring, replacment);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {code}");
        }
    }
}
