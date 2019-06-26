using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            var boxes = new List<Box>();

            while (input != "end")
            {
                string[] data = input.Split();

                int serialNumber = int.Parse(data[0]);
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);
                decimal boxPrice = itemQuantity * itemPrice;

                var item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice
                };

                var box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    ItemQuantity = itemQuantity,
                    PriceForBox = boxPrice
                };

                boxes.Add(box);

                input = Console.ReadLine();
            }

            var sortedBoxes = boxes.OrderByDescending(s => s.PriceForBox).ToList();

            foreach (var box in sortedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }
}

