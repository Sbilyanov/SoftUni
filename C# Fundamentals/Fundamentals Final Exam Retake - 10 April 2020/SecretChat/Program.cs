using System;
using System.Linq;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] command = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "InsertSpace":

                        int index = int.Parse(command[1]);
                        message=message.Insert(index," ");
                        Console.WriteLine(message);

                        break;

                    case "Reverse":

                        string substring = command[1];
                        if (message.Contains(substring))
                        {
                            int startIndex = message.IndexOf(substring);
                            message = message.Remove(startIndex, substring.Length);
                            var reversSub = String.Concat(substring.Reverse());
                            message += reversSub;
                            Console.WriteLine(message);

                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;
                    case "ChangeAll":


                        if (message.Contains(command[1]))
                        {
                            message=message.Replace(command[1], command[2]);
                            Console.WriteLine(message);
                        
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");

        }
    }
}
