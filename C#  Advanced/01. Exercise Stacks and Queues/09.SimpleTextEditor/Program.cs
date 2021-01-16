using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperation = int.Parse(Console.ReadLine());
            Queue<char> textQueue = new Queue<char>();
            Stack<char[]> commandQueue = new Stack<char[]>();
            char[] updateCommand = { };

            for (int i = 0; i < numberOfOperation; i++)
            {
                char[] command = Console.ReadLine().ToCharArray();
              
                switch (command[0])
                {
                    case '1':
                        commandQueue.Push(command);
                        
                        for (int j = 2; j < command.Length; j++)
                        {
                            textQueue.Enqueue(command[j]);
                            
                        }
                        updateCommand = command;
                        updateCommand[0] = '2';
                        break;
                    case '2':
                        
                        updateCommand[0] = '1';
                        commandQueue.Push(updateCommand);
                        for (int j = 0; j < command.Length; j++)
                        {
                            textQueue.Dequeue();
                        }
                        break;
                    case '3':
                        if (textQueue.Count >= (int.Parse(command[2].ToString())))
                        {
                            int element = int.Parse(command[2].ToString());
                            Console.WriteLine(textQueue.ElementAt(element-1));
                        }

                        break;
                    case '4':
                        command = commandQueue.Pop();

                        if (command[0] == '2')
                        {

                            for (int j = 2; j < command.Length; j++)
                            {
                                textQueue.Dequeue();
                            }
                        }
                        else if (command[0] == '1')
                        {

                            for (int j = 2; j < command.Length; j++)
                            {
                                textQueue.Enqueue(command[j]);
                            }
                        }
                        break;
                }

            }

        }
    }
}
