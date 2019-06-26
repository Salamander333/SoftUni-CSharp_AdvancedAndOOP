using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal studentCount = decimal.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            decimal priceSum;
            decimal change;

            decimal freeBelts = 0;
            //adding robe price
            priceSum = studentCount * robePrice;

            //adding lightsaber price
            priceSum = priceSum + ((studentCount + Math.Ceiling(studentCount * 0.1m)) * lightsaberPrice);

            //adding belt price
            freeBelts = Math.Floor(studentCount / 6m);
            priceSum = priceSum + ((studentCount - freeBelts) * beltPrice);

            change = budget - priceSum;
            if (change < 0)
            {
                change *= -1;
                Console.WriteLine($"Ivan Cho will need {change:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {priceSum:f2}lv.");
            }

        }
    }
}
