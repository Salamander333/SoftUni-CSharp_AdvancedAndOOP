﻿using System;

namespace _08._Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            string name = $"{input[0]} {input[1]}";
            string address = input[2];
            string town = input[3];
            var firstTuple = new Threeuple<string, string, string>(name, address, town);
            Console.WriteLine(firstTuple);

            input = Console.ReadLine().Split();
            name = input[0];
            int liters = int.Parse(input[1]);
            bool isDrunk = input[2] == "drunk" ? true : false;
            var secondTuple = new Threeuple<string, int, bool>(name, liters, isDrunk);
            Console.WriteLine(secondTuple);

            input = Console.ReadLine().Split();
            name = input[0];
            double bankBalance = double.Parse(input[1]);
            string bankName = input[2];
            var thirdTuple = new Threeuple<string, double, string>(name, bankBalance, bankName);
            Console.WriteLine(thirdTuple);
        }
    }
}
