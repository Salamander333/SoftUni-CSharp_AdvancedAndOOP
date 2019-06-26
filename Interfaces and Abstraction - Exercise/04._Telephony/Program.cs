using System;

namespace _04._Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersToCall = Console.ReadLine().Split();
            string[] websitesToBrowse = Console.ReadLine().Split();

            var smartphone = new Smartphony();

            foreach (var number in numbersToCall)
            {
                Console.WriteLine(smartphone.CallNumber(number));
            }

            foreach (var website in websitesToBrowse)
            {
                Console.WriteLine(smartphone.BrowseWebsite(website));
            }
        }
    }
}
