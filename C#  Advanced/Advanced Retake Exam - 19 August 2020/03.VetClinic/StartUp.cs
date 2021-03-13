using System;

namespace _03.VetClinic
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            // Initialize the repository
            Clinic clinic = new Clinic(20);

            // Initialize entity
            Pet dog = new Pet("Ellias", 5, "Tim");

            // Print Pet
            Console.WriteLine(dog); // Ellias 5 (Tim)

        }
    }
}
