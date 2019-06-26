using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int productCount = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < productCount; i++)
            {
                string productToAdd = Console.ReadLine();
                products.Add(productToAdd);
            }

            products.Sort();

            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
