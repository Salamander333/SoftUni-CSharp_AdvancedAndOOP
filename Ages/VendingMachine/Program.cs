using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal insertedMoney;
            decimal money = 0.00m;
            decimal price;

            while (input != "Start")
            {
                Decimal.TryParse(input, out insertedMoney);
                if (insertedMoney == 0.1m || insertedMoney == 0.2m || insertedMoney == 0.5m || insertedMoney == 1m || insertedMoney == 2m)
                {
                    money += insertedMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertedMoney}");
                }
                insertedMoney = 0;
                input = Console.ReadLine();
            }
            while (input != "End" )
            {
                switch (input)
                {
                    case "Nuts":
                        price = 2.0m;
                        if (money >= price)
                        {
                            Console.WriteLine("Purchased nuts");
                            money -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        price = 0.7m;
                        if (money >= price)
                        {
                            Console.WriteLine("Purchased water");
                            money -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        price = 1.5m;
                        if (money >= price)
                        {
                            Console.WriteLine("Purchased crisps");
                            money -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        price = 0.8m;
                        if (money >= price)
                        {
                            Console.WriteLine("Purchased soda");
                            money -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        price = 1.0m;
                        if (money >= price)
                        {
                            Console.WriteLine("Purchased coke");
                            money -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Start":
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {money}");

        }
    }
}
