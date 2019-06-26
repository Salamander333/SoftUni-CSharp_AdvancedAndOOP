using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int result = 0;
            int three = 0;
            int four = 0;

            for (int ia = 0; ia <= a; ia++)
            {
                for (int ib = 0; ib <= b; ib++)
                {
                    for (int ic = 0; ic <= c; ic++)
                    {
                        for (int id = 0; id <= d; id++)
                        {
                            Console.Write(ia);
                            Console.Write(ib);
                            Console.Write(ic);
                            Console.Write(id);
                            Console.WriteLine();

                            if (a != b && a != c && a != d && b != c && b != d && c!= d)
                            {
                                result += 20;
                            }
                            if (a != c && a == d && a == b)
                            {
                                result += 20;
                            }
                            if (a != b && a == c && a == d)
                            {
                                result += 20;
                            }

                            if (a == b && a != c && a != d)
                            {
                                result += 20;
                            }
                            if (a != b && a == c && a != d)
                            {
                                result += 20;
                            }
                            if (a != b && a!= c && a == d)
                            {
                                result += 20;
                            }
                            if (b!= a && b == c && b != d)
                            {
                                result += 20;

                            }
                            if (b!= a && b!= c && b== d)
                            {
                                result += 20;


                            }
                            if (c!= a && c == b && c != d)
                            {
                                result += 20;
                            }
                            if (c!= a && c!= b && c == d)
                            {
                                result += 20;
                            }

                            if (a == b && a== c && a != d)
                            {
                                three++;
                                result += 100;
                            }
                            if (a != b && b == c && b == d)
                            {
                                three++;
                                result += 100;
                            }
                            if (a == b && b==c && c == d)
                            {
                                four++;
                                result += 1000;
                            }
                        }

                    }
                }
            }
            Console.WriteLine("Final sum: {0}", result);
            Console.WriteLine("Car numbers with 3 equal digits: {0}", three);
            Console.WriteLine("Car numbers with 4 equal digits: {0}", four);
        }
    }
}
