using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string birth = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime result = DateTime.ParseExact(birth, format, null);
            DateTime output = result.AddDays(999);
            Console.WriteLine(output.ToString("dd-MM-yyyy"));
        }
    }
}
