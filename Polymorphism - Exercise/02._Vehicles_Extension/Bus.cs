using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Vehicles_Extension
{
    class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public string DriveEmpty(double distance)
        {
            if (FuelConsumptionInLitersPerKM * distance < FuelQuantity)
            {
                this.FuelQuantity -= (FuelConsumptionInLitersPerKM * distance);
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public override string Drive(double distance)
        {
            if ((FuelConsumptionInLitersPerKM + 1.4) * distance < FuelQuantity)
            {
                this.FuelQuantity -= ((FuelConsumptionInLitersPerKM + 1.4) * distance);
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }
    }
}
