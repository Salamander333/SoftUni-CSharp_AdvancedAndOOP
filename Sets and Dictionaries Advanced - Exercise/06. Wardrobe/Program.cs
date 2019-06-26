using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ").ToList();

                var color = input[0];
                var clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string cloth = clothes[j];

                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color][cloth] = 0;
                    }

                    wardrobe[color][cloth]++;
                }
            }

            var whatToLookFor = Console.ReadLine().Split(" ");

            var colorToSearch = whatToLookFor[0];
            var clothesToSearch = whatToLookFor[1];

            foreach (var kvp in wardrobe)
            {
                string color = kvp.Key;
                var clothCount = kvp.Value;

                Console.WriteLine($"{color} clothes:");

                foreach (var kvpToMatch in clothCount)
                {
                    string cloth = kvpToMatch.Key;
                    int count = kvpToMatch.Value;

                    if (color == colorToSearch && cloth == clothesToSearch)
                    {
                        Console.WriteLine($"* {cloth} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {count}");
                    }
                }
            }
        }
    }
}
