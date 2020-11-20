using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string longNumber = Console.ReadLine().Trim('0');
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            int fristDigit = 0;

            if (number==0 ||longNumber=="")
            {
                Console.WriteLine(0);
                return;
            }

            foreach (var item in longNumber.Reverse())
            {

                int digit = int.Parse(item.ToString());
                result = digit * number+fristDigit;

                int last = result % 10;
                fristDigit = result / 10;

                sb.Insert(0, last);
            }
            if (fristDigit>0)
            {
                sb.Insert(0, fristDigit);
            }

            Console.WriteLine(sb);
        }
    }
}
