using System;

namespace _03._Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = Console.ReadLine();
            var ferrari = new Ferrari(driver);
            Console.WriteLine(ferrari.ToString());
        }
    }
}
