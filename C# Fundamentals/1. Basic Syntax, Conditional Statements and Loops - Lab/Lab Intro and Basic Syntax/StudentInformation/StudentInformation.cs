using System;

namespace StudentInformation
{
    class StudentInformation
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {averageGrade:F2}");
           
        }
    }
}
