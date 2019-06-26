using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Company_Roster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();
            var departments = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < lineCount; i++)
            {
                var employeeInfo = Console.ReadLine().Split();

                var name = employeeInfo[0];
                var salary = decimal.Parse(employeeInfo[1]);
                var position = employeeInfo[2];
                var department = employeeInfo[3];

                if (!departments.ContainsKey(department))
                {
                    departments.Add(department, new List<decimal>());
                }
                departments[department].Add(salary);

                if (employeeInfo.Length == 4)
                {
                    var employee = new Employee(name, salary, position, department);
                    employees.Add(employee);
                }
                else if (employeeInfo.Length == 6)
                {
                    var email = employeeInfo[4];
                    var age = int.Parse(employeeInfo[5]);
                    var employee = new Employee(name, salary, position, department, email, age);
                    employees.Add(employee);
                }
                else
                {
                    int age = -1;
                    bool isAge = int.TryParse(employeeInfo[4], out age);

                    if (isAge)
                    {
                        age = int.Parse(employeeInfo[4]);
                        var employee = new Employee(name, salary, position, department, age);
                        employees.Add(employee);
                    }

                    else
                    {
                        string email = employeeInfo[4];
                        var employee = new Employee(name, salary, position, department, email);
                        employees.Add(employee);
                    }
                }
            }

            var bestDepartment = departments.OrderByDescending(x => x.Value.Average()).First();

            var bestDepartmentEmployees = employees.Where(x => x.Department == bestDepartment.Key).OrderByDescending(x => x.Salary).ToList();


            Console.WriteLine($"Highest Average Salary: {bestDepartment.Key}");
            foreach (var employee in bestDepartmentEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
