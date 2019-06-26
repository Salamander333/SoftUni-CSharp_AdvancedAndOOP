using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Shopping_Spree
{
    class Person
    {
        private string name;
        private int money;
        private List<Product> bag;

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name cannot be empty");
                    Environment.Exit(0);
                }

                this.name = value;
            }
        }

        public int Money
        {
            get => this.money;

            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Money cannot be negative");
                    Environment.Exit(0);
                }

                this.money = value;
            }
        }

        public List<Product> Bag { get; set; }

        public void BuyProduct(Product product)
        {
            if (this.Money - product.Cost < 0)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
                return;
            }

            this.Bag.Add(product);
            this.Money -= product.Cost;
            Console.WriteLine($"{this.Name} bought {product.Name}");
        }

        public override string ToString()
        {
            if (this.Bag.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            else
            {
                return $"{this.Name} - {string.Join(", ", this.Bag.Select(x => x.Name))}";
            }
        }
    }
}
