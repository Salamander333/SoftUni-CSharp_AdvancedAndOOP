using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Vehicles_Extension
{
    class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumptionInLitersPerKM += 1.6;
        }
    }
}
