using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal clientCount = decimal.Parse(Console.ReadLine());
            string clientType = Console.ReadLine();
            string clientDay = Console.ReadLine();

            decimal price = 0;

            if (clientType == "Students")
            {
                if (clientDay == "Friday")
                {
                    price = 8.45m * clientCount;
                }
                else if (clientDay == "Saturday")
                {
                    price = 9.80m * clientCount;
                }
                else if (clientDay == "Sunday")
                {
                    price = 10.46m * clientCount;
                }
            }
            else if (clientType == "Business")
            {
                if (clientCount >= 100)
                {
                    if (clientDay == "Friday")
                    {
                        price = 10.90m * (clientCount - 10);
                    }
                    else if (clientDay == "Saturday")
                    {
                        price = 15.60m * (clientCount - 10);
                    }
                    else if (clientDay == "Sunday")
                    {
                        price = 16 * (clientCount - 10);
                    }
                }
                else
                {
                    if (clientDay == "Friday")
                    {
                        price = 10.90m * clientCount;
                    }
                    else if (clientDay == "Saturday")
                    {
                        price = 15.60m * clientCount;
                    }
                    else if (clientDay == "Sunday")
                    {
                        price = 16 * clientCount;
                    }
                }
            }
            else if (clientType == "Regular")
            {
                if (clientDay == "Friday")
                {
                    price = 15 * clientCount;
                }
                else if (clientDay == "Saturday")
                {
                    price = 20 * clientCount;

                }
                else if (clientDay == "Sunday")
                {
                    price = 22.50m * clientCount;
                }
            }
            if (clientType == "Students")
            {
                if (clientCount >= 30)
                {
                    price = price - (price * 0.15m);
                }
            }
            else if (clientType == "Regular")
            {
                if (clientCount >= 10 && clientCount <= 20)
                {
                    price = price - (price * 0.05m);
                }
            }

            Console.WriteLine($"Total price: {price:f2}");
        }

    }
}
