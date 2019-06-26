using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using _08._Military_Elite.Interfaces;

namespace _08._Military_Elite.SoldierTypes
{
    class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps, List<Repair> repairs) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<Repair>();
            this.Repairs = repairs;
        }

        public List<Repair> Repairs { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Coprs}");
            sb.AppendLine("Repairs:");
            foreach (var repair in Repairs)
            {
                sb.AppendLine("  " + repair.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
