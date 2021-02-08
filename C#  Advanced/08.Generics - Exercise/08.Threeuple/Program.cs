using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] threeupleOneData = Console.ReadLine().Split();
            string fullName = $"{threeupleOneData[0]} {threeupleOneData[1]}";
            List<string> townData = threeupleOneData.Skip(3).ToList();
            string town = string.Join(' ', townData);
            Threeuple<string, string,string> threeupleOne = new Threeuple<string, string, string>
                (fullName, threeupleOneData[2],town);

            string[] threeupleTwoData = Console.ReadLine().Split();
            bool drunk = threeupleTwoData[2] == "drunk" ? true : false;

 
            Threeuple<string, int, bool> threeupleTwo = new Threeuple<string, int, bool>
                (threeupleTwoData[0], int.Parse(threeupleTwoData[1]), drunk);

            string[] threeupleThreeData = Console.ReadLine().Split();
            Threeuple<string, double, string> threeupleThree = new Threeuple<string, double, string>
                (threeupleThreeData[0], double.Parse(threeupleThreeData[1]), threeupleThreeData[2]);

            Console.WriteLine(threeupleOne);
            Console.WriteLine(threeupleTwo);
            Console.WriteLine(threeupleThree);
        }
    }
}
