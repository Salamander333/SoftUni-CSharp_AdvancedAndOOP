using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Vehicles
{
    abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.DistanceTraveled = 0;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionInLitersPerKM = fuelConsumption;
        }

        public double DistanceTraveled { get; protected set; }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumptionInLitersPerKM { get; protected set; }

        public string Drive(double distance)
        {
            if (FuelConsumptionInLitersPerKM * distance < FuelQuantity)
            {
                this.FuelQuantity -= (FuelConsumptionInLitersPerKM * distance);
                this.DistanceTraveled += distance;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public abstract void Refuel(double amount);

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
