using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Vehicles_Extension
{
    abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                this.FuelQuantity = 0;
            }
            else
            {
                this.FuelQuantity = fuelQuantity;
            }
            this.FuelConsumptionInLitersPerKM = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double TankCapacity { get; protected set; }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumptionInLitersPerKM { get; protected set; }


        public virtual string Drive(double distance)
        {
            if (this.FuelConsumptionInLitersPerKM * distance <= this.FuelQuantity)
            {
                this.FuelQuantity -= (this.FuelConsumptionInLitersPerKM * distance);
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (amount + this.FuelQuantity > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            }

            switch (this.GetType().Name)
            {
                case "Car":
                case "Bus":
                    this.FuelQuantity += amount;
                    break;
                case "Truck":
                    amount *= 0.95;
                    this.FuelQuantity += amount;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
