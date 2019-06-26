using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {

            var companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] inputArr = input.Split(" -> ");
                string companyName = inputArr[0];
                string companyEmployee = inputArr[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(companyEmployee);
                }
                else
                {
                    if (!companies[companyName].Contains(companyEmployee))
                    {
                        companies[companyName].Add(companyEmployee);
                    }
                }
            }

            companies = companies.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in companies)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (string id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
