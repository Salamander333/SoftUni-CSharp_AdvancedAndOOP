using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Pizza_Calories
{
    class Topping
    {
        private string type;
        private int weightInGrams;
        private string typeOriginal;

        public Topping(string type, int weightInGrams)
        {
            this.Type = type;
            this.WeightInGrams = weightInGrams;
        }

        private string Type
        {
            get => this.type;
            set
            {
                this.typeOriginal = value;
                string type = value.ToLower();

                switch (type)
                {
                    case "meat":
                    case "veggies":
                    case "cheese":
                    case "sauce":
                        this.type = type;
                        break;

                    default:
                        Console.WriteLine($"Cannot place {typeOriginal} on top of your pizza.");
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private int WeightInGrams
        {
            get => this.weightInGrams;
            set
            {
                if (value >= 1 && value <= 50)
                {
                    this.weightInGrams = value;
                    return;
                }

                Console.WriteLine($"{this.typeOriginal} weight should be in the range [1..50].");
                Environment.Exit(0);
            }
        }

        public double CalculateCalories()
        {
            double typeModifier = 0;

            switch (this.Type)
            {
                case "meat":
                    typeModifier = 1.2;
                    break;
                case "veggies":
                    typeModifier = 0.8;
                    break;
                case "cheese":
                    typeModifier = 1.1;
                    break;
                case "sauce":
                    typeModifier = 0.9;
                    break;
            }

            double calc = (2 * this.WeightInGrams) * typeModifier;
            return calc;
        }
    }
}
