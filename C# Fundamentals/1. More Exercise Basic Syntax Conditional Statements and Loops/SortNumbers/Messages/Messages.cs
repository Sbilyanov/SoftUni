using System;
using System.Globalization;

namespace Messages
{
    class Messages
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string massege = string.Empty;
           
            

            for (int i = 1; i <=input; i++)
            {
                string currenNumber = Console.ReadLine();
                int digitLenght = currenNumber.Length;

                int digit = int.Parse(currenNumber) % 10;

                int offset = (digit - 2) * 3;
          
                if ( digit == 9 || digit== 8)
                {
                    offset ++;
                }
                if (digit == 0)
                {
                    massege += " ";
                    offset = 0;
                    continue;
                }

                int lettersIdnex = (offset + digitLenght - 1);
                
                massege += (char)(lettersIdnex + 97);
            }

            Console.WriteLine(massege);


        }
    }
}
