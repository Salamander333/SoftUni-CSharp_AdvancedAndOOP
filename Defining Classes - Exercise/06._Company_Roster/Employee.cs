using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Company_Roster
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public string Name
        {
            get { return name; }
        }
        public decimal Salary
        {
            get { return salary; }
        }
        public string Position
        {
            get { return position; }
        }
        public string Department
        {
            get { return department; }
        }
        public string Email
        {
            get { return email; }
        }
        public int Age
        {
            get { return age; }
        }

        public Employee(string name, decimal salary, string position, string department, string email, int age)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = email;
            this.age = age;
        }

        public Employee(string name, decimal salary, string position, string department)
            : this(name, salary, position, department, "n/a", -1) { }

        public Employee(string name, decimal salary, string position, string department, string email)
            : this(name, salary, position, department, email, -1) { }

        public Employee(string name, decimal salary, string position, string department, int age)
            : this(name, salary, position, department,"n/a", age) { }

        public override string ToString()
        {
            return $"{this.name} {this.salary:f2} {this.email} {this.age}";
        }
    }
}
