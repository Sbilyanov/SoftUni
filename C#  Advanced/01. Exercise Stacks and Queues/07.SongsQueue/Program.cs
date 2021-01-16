using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songsQueue = new Queue<string>(input);
          
       
            while (songsQueue.Any())
            {
                string token = Console.ReadLine();
                string[] command = token.Split();

                switch (command[0])
                {
                    case "Play":
                        songsQueue.Dequeue();
                        break;
                    case "Add":
                        string songFullname = token.Substring(4);

                        if (songsQueue.Contains(songFullname))
                        {
                            Console.WriteLine($"{songFullname} is already contained!");
                        }
                        else
                        {
                            songsQueue.Enqueue(songFullname);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",songsQueue));
                        break;
                
                }

            }
            Console.WriteLine("No more songs!");

        }
    }
}
