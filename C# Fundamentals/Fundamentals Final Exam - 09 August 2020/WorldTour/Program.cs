using System;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string tour = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] command = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Add Stop":
                        int index = int.Parse(command[1]);
                        string addStop = command[2];
                        if (index >= 0 && index < tour.Length)
                        {
                            tour = tour.Insert(index, addStop);
                        }
                        Console.WriteLine(tour);


                        break;

                    case "Remove Stop":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        if (startIndex >= 0 && startIndex < tour.Length &&
                            endIndex >= 0 && endIndex < tour.Length)
                        {
                            tour = tour.Remove(startIndex, (endIndex - startIndex) + 1);
                        }
                        Console.WriteLine(tour);

                        break;
                    case "Switch":
                        string oldStop = command[1];
                        string newStop = command[2];
                        if (tour.Contains(oldStop))
                        {
                            tour = tour.Replace(oldStop, newStop);
                        }
                        Console.WriteLine(tour);

                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {tour}");
        }
    }
}
