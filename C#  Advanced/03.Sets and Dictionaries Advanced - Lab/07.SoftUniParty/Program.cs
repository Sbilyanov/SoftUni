using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            HashSet<string> guestList = new HashSet<string>();
            while (input!="PARTY")
            {
                guestList.Add(input);
          
                input = Console.ReadLine();
            }
            while (input!="END")
            {
                
                guestList.Remove(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(guestList.Count);

            foreach (string guest in guestList)
            {
                if (Char.IsDigit(guest[0]))
                {
                    string current = guest;
                    Console.WriteLine(guest);
                    
                }
              
            }
            foreach (var guest in guestList)
            {
                if (!Char.IsDigit(guest[0]))
                {
                    Console.WriteLine(guest);
                }
               
            }
        }
    }
}
