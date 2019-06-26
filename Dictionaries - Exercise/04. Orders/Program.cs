using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, Tuple<decimal, decimal>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "buy")
                {
                    break;
                }

                string itemName = input[0];
                decimal itemPrice = decimal.Parse(input[1]);
                decimal itemQuantity = decimal.Parse(input[2]);

                if (!items.ContainsKey(itemName))
                {
                    items.Add(itemName, new Tuple<decimal, decimal>(itemPrice, itemQuantity));
                }
                else
                {
                    decimal addedQuantity = items[itemName].Item2 + itemQuantity;
                    items[itemName] = new Tuple<decimal, decimal>(itemPrice, addedQuantity);
                }               
            }

            foreach (var kvp in items)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Item1 * kvp.Value.Item2}");
            }
        }
    }
}
