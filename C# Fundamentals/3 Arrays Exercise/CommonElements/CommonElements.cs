using System;
using System.Linq;

namespace CommonElements
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine()
                            .Split()
                            .ToArray();
            string[] arrayTwo = Console.ReadLine()
                            .Split()
                            .ToArray();
            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    if (arrayOne[i] == arrayTwo[j])
                        Console.Write(arrayOne[i] + " ");
                }
            }
        }
    }
}
}
