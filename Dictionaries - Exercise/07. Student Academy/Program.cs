using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            var studentsGrades = new Dictionary<string, List<double>>();
            var result = new Dictionary<string, double>();

            for (int i = 0; i < inputLines; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(studentName))
                {
                    studentsGrades.Add(studentName, new List<double>());
                }
                studentsGrades[studentName].Add(studentGrade);
            }

            foreach (var kvp in studentsGrades)
            {
                double averageGrade = kvp.Value.Average();

                if (!result.ContainsKey(kvp.Key))
                {
                    result.Add(kvp.Key, 0);
                }

                result[kvp.Key] = averageGrade;
            }

            result = result.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in result)
            {
                if (kvp.Value >= 4.50)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
                }
            }
        }
    }
}
