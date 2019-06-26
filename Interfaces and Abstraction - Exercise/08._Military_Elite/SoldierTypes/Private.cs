using System;
using System.Collections.Generic;
using System.Text;
using _08._Military_Elite.Interfaces;

namespace _08._Military_Elite.SoldierTypes
{
    class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, decimal salary) : base (id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {this.Salary:f2}";
        }
    }
}
