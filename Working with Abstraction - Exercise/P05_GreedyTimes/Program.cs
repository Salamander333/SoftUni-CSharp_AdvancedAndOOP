using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            string[] safeContents = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long gems = 0;
            long cash = 0;

            for (int i = 0; i < safeContents.Length; i += 2)
            {
                string name = safeContents[i];
                long contentCount = long.Parse(safeContents[i + 1]);

                string contentType = CheckType(name);

                bool skipContent = ShouldContentBeSkipped(contentType, contentCount, bag, bagCapacity);

                if (skipContent)
                {
                    continue;
                }

                if (!bag.ContainsKey(contentType))
                {
                    bag[contentType] = new Dictionary<string, long>();
                }

                if (!bag[contentType].ContainsKey(name))
                {
                    bag[contentType][name] = 0;
                }

                bag[contentType][name] += contentCount;
                if (contentType == "Gold")
                {
                    gold += contentCount;
                }
                else if (contentType == "Gem")
                {
                    gems += contentCount;
                }
                else if (contentType == "Cash")
                {
                    cash += contentCount;
                }
            }

            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }

        public static string CheckType(string type)
        {
            var contentType = string.Empty;

            if (type.Length == 3)
            {
                contentType = "Cash";
            }
            else if (type.ToLower().EndsWith("gem"))
            {
                contentType = "Gem";
            }
            else if (type.ToLower() == "gold")
            {
                contentType = "Gold";
            }

            return contentType;
        }

        public static bool ShouldContentBeSkipped(string contentType,
            long contentCount,
            Dictionary<string, Dictionary<string, long>> bag,
            long bagCapacity)
        {
            if (contentType == "")
            {
                return true;
            }
            else if (bagCapacity < bag.Values.Select(x => x.Values.Sum()).Sum() + contentCount)
            {
                return true;
            }

            switch (contentType)
            {
                case "Gem":
                    if (!bag.ContainsKey(contentType))
                    {
                        if (bag.ContainsKey("Gold"))
                        {
                            if (contentCount > bag["Gold"].Values.Sum())
                            {
                                return true;
                            }
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else if (bag[contentType].Values.Sum() + contentCount > bag["Gold"].Values.Sum())
                    {
                        return true;
                    }
                    break;
                case "Cash":
                    if (!bag.ContainsKey(contentType))
                    {
                        if (bag.ContainsKey("Gem"))
                        {
                            if (contentCount > bag["Gem"].Values.Sum())
                            {
                                return true;
                            }
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else if (bag[contentType].Values.Sum() + contentCount > bag["Gem"].Values.Sum())
                    {
                        return true;
                    }
                    break;
            }

            return false;
        }


    }
}