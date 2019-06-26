using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starNum = 0;

            for (int row = 0; row < (n + 1) / 2; row++)
            { 
                if (n % 2 == 0)
                {
                    starNum += 2;
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - starNum) / 2), new string('*', starNum), new string('-', (n - starNum) / 2));
                } else
                {
                    if (row == 0)
                    {
                        starNum += 1;
                    }
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - starNum) / 2), new string('*', starNum), new string('-', (n - starNum) / 2));
                    starNum += 2;
                }
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", "|", new string('*', n - 2), "|");
            }
        }
    }
}
