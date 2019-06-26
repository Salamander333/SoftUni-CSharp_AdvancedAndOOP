using System;
using System.Collections.Generic;

namespace _05._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] input_people = Console.ReadLine().Split(";");
            foreach (var p in input_people)
            {
                string[] person = p.Split("=");
                string person_name = person[0];
                int person_money = int.Parse(person[1]);

                people.Add(new Person { Name = person_name, Money = person_money, Bag = new List<string>() });
            }

            string[] input_products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var p in input_products)
            {
                string[] product = p.Split("=");
                string product_name = product[0];
                int product_price = int.Parse(product[1]);

                products.Add(new Product { ProductName = product_name, ProductPrice = product_price });
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] input = command.Split();
                Person person = people.Find(x => x.Name == input[0]);
                Product product = products.Find(x => x.ProductName == input[1]);

                if (Person.CanAffordProduct(person, product))
                {
                    person.Money -= product.ProductPrice;
                    person.Bag.Add(product.ProductName);
                    Console.WriteLine($"{person.Name} bought {product.ProductName}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.ProductName}");
                }

                command = Console.ReadLine();
            }

            foreach (var person in people)
            {
                string personsProducts = "";

                if (person.Bag.Count == 0)
                {
                    personsProducts = "Nothing bought";
                }
                else
                {
                    personsProducts = string.Join(", ", person.Bag);
                }

                Console.WriteLine($"{person.Name} - {personsProducts}");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public List<string> Bag { get; set; }

        public static bool CanAffordProduct(Person person, Product product)
        {
            if (product.ProductPrice <= person.Money)
            {
                return true;
            }

            return false;
        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
    }
}
