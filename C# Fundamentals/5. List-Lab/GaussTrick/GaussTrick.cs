using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class GaussTrick
    {
        static void Main(string[] args)
        {
          

            int origginalLenght = numbers.Count;

            for (int i = 0; i < origginalLenght/2; i++)
            {

                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);              
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
