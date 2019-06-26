using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Vehicles
{
    class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsumptionInLitersPerKM += 0.9;
        }

        public override void Refuel(double amount)
        {
            this.FuelQuantity += amount;
        }
    }
}
