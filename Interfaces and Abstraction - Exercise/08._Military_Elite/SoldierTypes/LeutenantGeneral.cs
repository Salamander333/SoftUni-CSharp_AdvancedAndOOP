using System;
using System.Collections.Generic;
using System.Text;
using _08._Military_Elite.Interfaces;

namespace _08._Military_Elite.SoldierTypes
{
    class LeutenantGeneral : Private, ILieutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, decimal salary, List<ISoldier> privates)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<ISoldier>();
            this.Privates = privates;
        }

        public List<ISoldier> Privates { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var soldier in Privates)
            {
                sb.AppendLine("  " + soldier.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
