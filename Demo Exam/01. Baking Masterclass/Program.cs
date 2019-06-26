using System;

namespace _01._Baking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());

            int freeFlour = studentCount / 5;
            decimal priceSum = 0.00m;

            priceSum = priceSum + ((studentCount - freeFlour) * flourPrice);
            priceSum = priceSum + ((studentCount * 10) * eggPrice);
            priceSum = priceSum + ((studentCount + Math.Ceiling(studentCount * 0.2m)) * apronPrice);

            if (budget >= priceSum)
            {
                Console.WriteLine($"Items purchased for {priceSum}$.");
            }
            else
            {
                decimal moreMoneyNeeded = priceSum - budget;
                Console.WriteLine($"{moreMoneyNeeded}$ more needed.");
            }
        }
    }
}
