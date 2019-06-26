using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionForOneKm;
        private double distanceTraveled;

        public string Model
        {
            get { return model; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
        }

        public double DistanceTraveled
        {
            get { return distanceTraveled; }
        }

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionForOneKm = fuelConsumption;
            this.distanceTraveled = 0;
        }

        public bool CanTravel(double distanceToTravel)
        {
            if (this.fuelAmount >= (distanceToTravel * fuelConsumptionForOneKm))
            {
                return true;
            }
            return false;
        }

        public void Travel(double distanceToTravel)
        {
            this.fuelAmount -= distanceToTravel * fuelConsumptionForOneKm;
            this.distanceTraveled += distanceToTravel;
        }
    }
}
