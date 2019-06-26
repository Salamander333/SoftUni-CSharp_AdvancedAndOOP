using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Vehicles
{
    class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsumptionInLitersPerKM += 1.6;
        }

        public override void Refuel(double amount)
        {
            amount *= 0.95;
            this.FuelQuantity += amount;
        }
    }
}
