using System;

namespace PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
  

            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double moneyNeeded = 0;

            beltPrice = (studentsCount - (studentsCount / 6))*beltPrice;
              

            lightsabersPrice = Math.Ceiling(studentsCount * 1.1)*lightsabersPrice;
           
            robePrice = robePrice * studentsCount;

            moneyNeeded = lightsabersPrice + beltPrice + robePrice;
   

            if (moneyNeeded<=budget)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {moneyNeeded-budget:f2}lv more.");
            }

        }
    }
}
