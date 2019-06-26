using System;
using System.Collections.Generic;
using System.Text;
using _08._Military_Elite.Interfaces;

namespace _08._Military_Elite.SoldierTypes
{
    class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Coprs = corps;
        }

        public string Coprs
        {
            get => this.corps;
            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException();
                }

                this.corps = value;
            }
        }
    }
}
