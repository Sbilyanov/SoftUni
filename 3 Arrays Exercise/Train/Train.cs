using System;
using System.Linq;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            int[] array = new int[(int.Parse(Console.ReadLine()))];
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int wagons = int.Parse(Console.ReadLine());
                array[i] = wagons;
                result += array[i];
            }
            Console.WriteLine(string.Join(' ', array));
            Console.WriteLine(result);
        }
    }
}
