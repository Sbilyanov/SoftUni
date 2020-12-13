using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
    
{
    class Mails
    {
        public string Name { get; set; }

        public List<string> Message { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
    class Problem3L
    {
        static void Main(string[] args)
        {
            List<Mails> mailList = new List<Mails>();

            string input = Console.ReadLine();

            while(input!="Statistics")
            {
                string[] command = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Add":
                        if (!mailList.Any(n=>n.Name==command[1]))
                        {
                            mailList.Add(new Mails { Name = command[1], Message = new List<string>()});
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} is already registered");
                        }
                        break;
                    case "Send":

                        string name = command[1];
                        var text = command[2];
                        int index = mailList.FindIndex(x => x.Name == [command[1]]);
                        mailList[index].Message.Add(command[2]);

                        break;

                    case "Delete":

                        if (mailList.Any(n=>n.Name==command[1]))
                        {
                            Mails current = mailList.FirstOrDefault(n => n.Name == command[1]);
                            mailList.Remove(current);
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} not found!");
                        }
                        break;              
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"User count:{mailList.Count}" );
            foreach (Mails name in mailList.OrderByDescending(v=>v.Message.Count).ThenBy(n=>n.Name))
            {
                Console.WriteLine($"{name.Name}");

                foreach (var item in name.Message)
                {
                    Console.WriteLine($"- {item}");

                }
            }
        }
    }
}
