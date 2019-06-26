using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int productQuantity = int.Parse(Console.ReadLine());

            CheckOut(productName, productQuantity);
        }

        static void CheckOut(string product, int quantity)
        {
            decimal price = 0.00m;

            switch (product)
            {
                case "coffee":
                    price = 1.50m;
                    break;
                case "water":
                    price = 1.00m;
                    break;
                case "coke":
                    price = 1.40m;
                    break;
                case "snacks":
                    price = 2.00m;
                    break;
            }

            Console.WriteLine(price * quantity);
        }
    }
}
