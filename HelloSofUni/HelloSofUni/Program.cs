using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSofUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i =1; i <= n - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', n - 2) + "*");
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
