using System;

namespace VacationV2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal clientCount = decimal.Parse(Console.ReadLine());
            string clientType = Console.ReadLine();
            string day = Console.ReadLine();

            decimal Price = 0;
            decimal totalPrice = 0;

            switch (clientType)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            Price = 8.45m;
                            break;
                        case "Saturday":
                            Price = 9.80m;
                            break;
                        case "Sunday":
                            Price = 10.46m;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            Price = 10.90m;
                            break;
                        case "Saturday":
                            Price = 15.60m;
                            break;
                        case "Sunday":
                            Price = 16.00m;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            Price = 15.00m;
                            break;
                        case "Saturday":
                            Price = 20.00m;
                            break;
                        case "Sunday":
                            Price = 22.50m;
                            break;
                    }
                    break;
            }
            if (clientType == "Students" && clientCount >= 30)
            {
                totalPrice = (clientCount * Price) * 0.85m;
            }
            else if (clientType == "Students")
            {
                totalPrice = clientCount * Price;
            }
            if (clientType == "Business" && clientCount >= 100)
            {
                totalPrice = (clientCount - 10) * Price;
            }
            else if (clientType == "Business")
            {
                totalPrice = clientCount * Price;
            }
            if (clientType == "Regular" && clientCount >= 10 && clientCount <= 20)
            {
                totalPrice = (clientCount * Price) * 0.95m;
            }
            else if (clientType == "Regular")
            {
                totalPrice = clientCount * Price;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
