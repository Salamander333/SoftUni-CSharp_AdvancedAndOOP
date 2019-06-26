using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var invited = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var filters = new List<string>();
            Predicate<string> predicate;

            while (true)
            {
                var input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                var command = input[0];
                if (command == "Print")
                {
                    break;
                }

                var filter = $"{input[1]};{input[2]}";
                if (command == "Remove filter")
                {
                    filters.RemoveAt(filters.FindIndex(x => x.EndsWith(input[2])));
                }
                else
                {
                    filters.Add(filter);
                }
            }

            foreach (var _filter in filters)
            {
                var filter = _filter.Split(";");
                var filterType = filter[0];
                var filterParam = filter[1];

                predicate = SetPredicate(filterType, filterParam);
                invited.RemoveAll(predicate);
            }

            Console.WriteLine(string.Join(" ", invited));
        }

        public static Predicate<string> SetPredicate(string filterType, string filterParam)
        {
            switch (filterType)
            {
                case "Starts with":
                    return p => p.StartsWith(filterParam);

                case "Ends with":
                    return p => p.EndsWith(filterParam);

                case "Contains":
                    return p => p.Contains(filterParam);

                case "Length":
                    return p => p.Length == int.Parse(filterParam);
            }

            return null;
        }
    }
}
