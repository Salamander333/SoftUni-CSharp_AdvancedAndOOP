using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumberList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondNumberList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int shortestListLenght = 0;
            bool firstListIsShortest = false;
            bool secondListIsShortest = false;

            List<int> result = new List<int>();

            if (firstNumberList.Count > secondNumberList.Count)
            {
                shortestListLenght = secondNumberList.Count;
                secondListIsShortest = true;
            }
            else if (firstNumberList.Count < secondNumberList.Count)
            {
                shortestListLenght = firstNumberList.Count;
                firstListIsShortest = true;
            }
            else if (firstNumberList.Count == secondNumberList.Count)
            {
                shortestListLenght = firstNumberList.Count;
            }

            for (int i = 0; i < shortestListLenght; i++)
            {
                result.Add(firstNumberList[i]);
                result.Add(secondNumberList[i]);
            }

            if (firstListIsShortest)
            {
                for (int i = shortestListLenght + 1; i <= secondNumberList.Count; i++)
                {
                    result.Add(secondNumberList[i - 1]);
                }
            }
            else if (secondListIsShortest)
            {
                for (int i = shortestListLenght + 1; i <= firstNumberList.Count; i++)
                {
                    result.Add(firstNumberList[i - 1]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
