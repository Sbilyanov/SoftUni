using System;
using System.Linq;

namespace _03.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stack = new MyStack<string>(Console.ReadLine()
              .Split(new char[]{' ',',' }, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList());

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Pop":
                        try
                        {
                        stack.Pop();

                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Push":
                        for (int i = 1; i < command.Length; i++)
                        {
                            stack.Push(command[i]);
                        } 

                        break;

                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine, stack));
            Console.WriteLine(string.Join(Environment.NewLine, stack));
         
        }
    }
}
