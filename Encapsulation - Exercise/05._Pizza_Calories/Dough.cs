using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Pizza_Calories
{
    class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weightInGrams;

        public Dough(string flourType, string bakingtechnique, int weightInGrams)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingtechnique;
            this.WeightInGrams = weightInGrams;
        }

        private string FlourType
        {
            get => this.flourType;

            set
            {
                switch (value)
                {
                    case "white":
                        this.flourType = value;
                        break;

                    case "wholegrain":
                        this.flourType = value;
                        break;

                    default:
                        Console.WriteLine("Invalid type of dough.");
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private string BakingTechnique
        {
            get => this.bakingTechnique;

            set
            {
                switch (value)
                {
                    case "crispy":
                    case "chewy":
                    case "homemade":
                        this.bakingTechnique = value;
                        break;

                    default:
                        Console.WriteLine("Invalid type of dough.");
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
                if (value >= 1 && value <= 200)
                {
                    this.weightInGrams = value;
                    return;
                }

                Console.WriteLine("Dough weight should be in the range [1..200].");
                Environment.Exit(0);
            }
        }

        public double CalculateCalories()
        {
            double flourTypeModifier = 0;
            double bakingTechniqueModifier = 0;

            switch (this.FlourType)
            {
                case "white":
                    flourTypeModifier = 1.5;
                    break;
                case "wholegrain":
                    flourTypeModifier = 1.0;
                    break;
            }

            switch (this.BakingTechnique)
            {
                case "crispy":
                    bakingTechniqueModifier = 0.9;
                    break;
                case "chewy":
                    bakingTechniqueModifier = 1.1;
                    break;
                case "homemade":
                    bakingTechniqueModifier = 1.0;
                    break;
            }

            double calc = (2 * this.WeightInGrams) * flourTypeModifier * bakingTechniqueModifier;
            return calc;
        }
    }
}
