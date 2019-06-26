using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    break;
                }

                string[] input = inputLine.Split(":");

                string course = input[0];
                course = course.TrimEnd(' ');
                string name = input[1];
                name = name.TrimStart(' ');

                if (!courses.ContainsKey(course))
                {
                    var list = new List<string>();
                    list.Add(name);
                    courses.Add(course, list);
                }
                else
                {
                    courses[course].Add(name);
                }
            }

            courses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, y => y.Value);

            foreach (var course in courses)
            {
                int studentCount = course.Value.Count;
                Console.WriteLine($"{course.Key}: {studentCount}");

                List<string> temp = course.Value;
                temp.Sort();

                foreach (string student in temp)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
