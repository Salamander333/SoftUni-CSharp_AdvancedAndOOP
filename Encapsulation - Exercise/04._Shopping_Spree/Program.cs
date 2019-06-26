using System;
using System.Collections.Generic;

namespace _04._Shopping_Spree
{
    class Program
    {
        static void Main()
        {
            var people = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            var products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            var peopleDb = new List<Person>();
            var productsDb = new List<Product>();

            foreach (var person in people)
            {
                var args = person.Split("=");
                var name = args[0];
                var money = int.Parse(args[1]);

                var temp = new Person(name, money);
                peopleDb.Add(temp);
            }

            foreach (var product in products)
            {
                var args = product.Split("=", StringSplitOptions.RemoveEmptyEntries);
                var name = args[0];
                var cost = int.Parse(args[1]);

                var temp = new Product(name, cost);
                productsDb.Add(temp);
            }

            while (true)
            {
                var command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    break;
                }

                var person = peopleDb.Find(x => x.Name == command[0]);
                var productToBuy = productsDb.Find(x => x.Name == command[1]);

                person.BuyProduct(productToBuy);
            }

            foreach (var person in peopleDb)
            {
                Console.WriteLine(person);
            }
        }
    }
}
