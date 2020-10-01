using System;
using System.ComponentModel.Design;

namespace EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string vowels = "EeUuIiOoAa";
            int[] arraySum = new int[lines];




            for (int i = 0; i < lines; i++)
            {
                char[] currentName = Console.ReadLine().ToCharArray();
                int sumVowels = 0;
                int sumConsonant = 0;


                int sum =0;
                for (int j = 0; j < currentName.Length; j++)
                {
                    char currentletter = currentName[j];

                    if (vowels.Contains(currentletter))
                    {
                        sumVowels += currentletter*currentName.Length;

                    }
                    else
                    {
                        sumConsonant += currentletter/currentName.Length;
                    }

                    sum = sumVowels + sumConsonant;
                      arraySum[i] = sum;
                }
            }
            Array.Sort(arraySum);
            for (int i = 0; i < arraySum.Length; i++)
            {
                Console.WriteLine(arraySum[i]);
            }
        }
       
    }
}
