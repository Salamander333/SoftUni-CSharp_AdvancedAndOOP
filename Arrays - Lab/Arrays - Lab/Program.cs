using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int dayInput = int.Parse(Console.ReadLine());

            if (dayInput >= 1 && dayInput <= 7)
            {
                Console.WriteLine(days[dayInput - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
