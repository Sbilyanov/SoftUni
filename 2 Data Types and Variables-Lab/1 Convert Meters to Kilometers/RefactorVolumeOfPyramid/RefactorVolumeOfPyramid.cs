using System;

namespace RefactorVolumeOfPyramid
{
    class RefactorVolumeOfPyramid
    {
        static void Main(string[] args)
        {
            

          
             double lenght = double.Parse(Console.ReadLine());
         
            double width = double.Parse(Console.ReadLine());
          
            double high = double.Parse(Console.ReadLine());
            double volume = (lenght * width * high) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");

        }
    }
}
