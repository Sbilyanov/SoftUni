using System;

namespace VendingMachine
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalSum = 0;


            while (input != "Start")
            {
                double currentCoin = double.Parse(input);
                bool validMoney = currentCoin == 0.1 ||
                                   currentCoin == 0.2 ||
                                   currentCoin == 0.5 ||
                                     currentCoin == 1 ||
                                     currentCoin == 2;

                if (validMoney)
                {
                    totalSum += currentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }

                input = Console.ReadLine();

            }
            string product = Console.ReadLine();
            
            while (product != "End")
            {
                double productPrice = 0;
                switch (product)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }
                if (productPrice<=totalSum)
                {
                    totalSum -= productPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }

                else if(totalSum < productPrice)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalSum:F2}");
        }
    }
}
