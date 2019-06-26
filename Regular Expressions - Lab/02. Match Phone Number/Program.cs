using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"([+]359)([-]|\s)([2])\2([0-9]{3}\b)\2([0-9]{4}\b)";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regex);

            var matchedPhones = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
