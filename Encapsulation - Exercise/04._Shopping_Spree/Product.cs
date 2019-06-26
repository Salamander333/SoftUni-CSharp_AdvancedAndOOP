using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Shopping_Spree
{
    class Product
    {
        private string name;
        private int cost;

        public Product(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name { get; set; }

        public int Cost
        {
            get => this.cost;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Money cannot be negative");
                    Environment.Exit(0);
                }

                this.cost = value;
            }
        }
    }
}
