using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Pizza_Calories
{
    class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, Dough dough, List<Topping> toppings)
        {
            this.Name = name;
            this.Toppings = toppings;
            this.Dough = dough;
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.Length >= 1 && value.Length <= 15)
                    {
                        this.name = value;
                        return;
                    }
                }

                Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                Environment.Exit(0);
            }
        }

        private List<Topping> Toppings
        {
            get => this.toppings;
            set
            {
                if (value.Count >= 0 && value.Count <= 10)
                {
                    this.toppings = value;
                    return;
                }

                Console.WriteLine("Number of toppings should be in range [0..10].");
                Environment.Exit(0);
            }
        }

        private Dough Dough
        {
            get => this.dough;
            set
            {
                this.dough = value;
            }
        }

        public int GetToppingCount { get => this.Toppings.Count; }

        public double GetTotalCalories()
        {
            double total = Dough.CalculateCalories();
            foreach (var topping in toppings)
            {
                total += topping.CalculateCalories();
            }
            return total;
        }
    }
}
