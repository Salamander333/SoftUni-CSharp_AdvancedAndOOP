using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearType = Console.ReadLine().ToLower();
            var p = double.Parse(Console.ReadLine());
            var weekendsInHomeTown = double.Parse(Console.ReadLine());

            double weekends = 48;
            double weekendsInSofia = weekends - weekendsInHomeTown;
            double gamesInSofia = weekendsInSofia * 3 / 4;
            double pGames = p * 2 / 3;

            double sumGames = gamesInSofia + pGames + weekendsInHomeTown;
            var leapYearBonus = sumGames * 0.15;
            if (yearType == "leap")
            {
                Console.WriteLine(Math.Truncate(sumGames + leapYearBonus));
            } else if (yearType == "normal")
            {
                Console.WriteLine(Math.Truncate(sumGames));
            }

        }
    }
}
