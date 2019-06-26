using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            var Employees = new List<Employee>();
            var Departments = new List<string>();


            int inputRows = int.Parse(Console.ReadLine());

            decimal highestAverageSalary = 0m;
            string departmentWithHighestAverageSalary = "";

            for (int i = 0; i < inputRows; i++)
            {
                string[] input = Console.ReadLine().Split();

                string employeeName = input[0];
                decimal employeeSalary = decimal.Parse(input[1]);
                string employeeDepartment = input[2];

                var employee = new Employee
                {
                    Name = employeeName,
                    Salary = employeeSalary,
                    Department = employeeDepartment
                };

                if (!Departments.Contains(employeeDepartment))
                {
                    Departments.Add(employeeDepartment);
                }

                Employees.Add(employee);
            }

            foreach (string depart in Departments)
            {
                List<Employee> temp = Employees.FindAll(x => x.Department == depart);

                var averageSalary = 0m;
                var salarySum = 0m;
                var employeeCount = 0;

                foreach (var emp in temp)
                {
                    salarySum += emp.Salary;
                    employeeCount++;
                }

                averageSalary = salarySum / employeeCount;

                if (highestAverageSalary == 0)
                {
                    highestAverageSalary = averageSalary;
                    departmentWithHighestAverageSalary = depart;
                }
                else if (averageSalary > highestAverageSalary)
                {
                    highestAverageSalary = averageSalary;
                    departmentWithHighestAverageSalary = depart;
                }
            }

            List<Employee> employeesWithBestAverage = Employees.FindAll(x => x.Department == departmentWithHighestAverageSalary);
            employeesWithBestAverage = employeesWithBestAverage.OrderByDescending(x => x.Salary).ToList();

            Console.WriteLine($"Highest Average Salary: {departmentWithHighestAverageSalary}");
            foreach (var employee in employeesWithBestAverage)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
            
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
}
