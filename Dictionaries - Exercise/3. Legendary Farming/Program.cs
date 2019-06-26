using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var usefulItems = new Dictionary<string, int>();

            usefulItems.Add("fragments", 0);
            usefulItems.Add("shards", 0);
            usefulItems.Add("motes", 0);

            var junkItems = new SortedDictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int itemCount = int.Parse(input[i]);
                    string itemName = input[i + 1];
                    itemName = itemName.ToLower();

                    switch (itemName)
                    {
                        case "shards":
                            
                            usefulItems[itemName] += itemCount;

                            if (usefulItems[itemName] >= 250)
                            {
                                usefulItems[itemName] -= 250;
                                usefulItems = usefulItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                                Console.WriteLine("Shadowmourne obtained!");
                                foreach (var kvp in usefulItems)
                                {
                                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                                }
                                foreach (var kvp in junkItems)
                                {
                                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                                }
                                return;
                            }

                            break;

                        case "fragments":
                            
                            usefulItems[itemName] += itemCount;

                            if (usefulItems[itemName] >= 250)
                            {
                                usefulItems[itemName] -= 250;
                                usefulItems = usefulItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                                Console.WriteLine("Valanyr obtained!");
                                foreach (var kvp in usefulItems)
                                {
                                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                                }
                                foreach (var kvp in junkItems)
                                {
                                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                                }
                                return;
                            }

                            break;

                        case "motes":
                            
                            usefulItems[itemName] += itemCount;

                            if (usefulItems[itemName] >= 250)
                            {
                                usefulItems[itemName] -= 250;
                                usefulItems = usefulItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
                                Console.WriteLine("Dragonwrath obtained!");
                                foreach (var kvp in usefulItems)
                                {
                                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                                }
                                foreach (var kvp in junkItems)
                                {
                                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                                }
                                return;
                            }
                            break;

                        default:
                            if (!junkItems.ContainsKey(itemName))
                            {
                                junkItems.Add(itemName, 0);
                            }
                            junkItems[itemName] += itemCount;
                            break;
                    }
                }
            }
        }
    }
}
