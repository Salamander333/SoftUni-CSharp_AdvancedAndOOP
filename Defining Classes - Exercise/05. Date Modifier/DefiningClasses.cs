using System;

namespace _05._Date_Modifier
{
    public class DefiningClasses
    {
        public static void Main(string[] args)
        {
            string date_1 = Console.ReadLine();
            string date_2 = Console.ReadLine();

            var diff = new DateModifier();
            Console.WriteLine(diff.FindDifference(date_1, date_2));
        }
    }
}
