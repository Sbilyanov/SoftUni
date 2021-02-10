using System;
using System.Linq;

namespace _02.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> list = new ListyIterator<string>(Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList());

            string command = Console.ReadLine();
            while (command != "END")
            {
                switch (command)
                {
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "Print":
                        try
                        {
                            list.Print();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                           
                        }
                        break;
                    case "PrintAll":
                        Console.Write(string.Join(' ',list));
                        Console.WriteLine();
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
