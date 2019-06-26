using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var curFrom = Console.ReadLine();
            var curTo = Console.ReadLine();
            var bgn = 1.0;
            var usd = 1.79549;
            var eur = 1.95583;
            var gpb = 2.53405;
            switch (curFrom)
            {
                case "BGN":
                    break;
                case "USD":
                    value = value * usd;
                    break;
                case "EUR":
                    value = value * eur;
                    break;
                case "GBP":
                    value = value * gpb;
                    break;
            }
            switch (curTo)
            {
                case "BGN":
                    value = value / bgn;
                    break;
                case "USD":
                    value = value / usd;
                    break;
                case "EUR":
                    value = value / eur;
                    break;
                case "GBP":
                    value = value / gpb;
                    break;
            }
            Console.WriteLine(Math.Round(value, 2) + " " + curTo);
        }
    }
}
