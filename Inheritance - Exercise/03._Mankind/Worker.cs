using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Mankind
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHourPerDay;
        private decimal salaryPerHour;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.salaryPerHour = CalculateSalaryPerHour();
        }

        public decimal WeekSalary
        {
            get => this.weekSalary;
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get => this.workHourPerDay;
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHourPerDay = value;
            }
        }

        private decimal CalculateSalaryPerHour()
        {
            return (this.WeekSalary / 5) / WorkHoursPerDay;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {base.FirstName}");
            sb.AppendLine($"Last Name: {base.LastName}");
            sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
            sb.Append($"Salary per hour: {this.salaryPerHour:f2}");
            return sb.ToString();
        }
    }
}
