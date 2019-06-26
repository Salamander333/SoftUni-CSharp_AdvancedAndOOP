using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Ferrari
{
    class Ferrari : ICar
    {
        public Ferrari( string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }

        public string Model { get; private set; }

        public string Driver { get; private set; }

        public string Brakes() => "Brakes!";

        public string GasPedal() => "Gas!";

        public override string ToString()
        {
            return $"488-Spider/{Brakes()}/{GasPedal()}/{Driver}";
        }
    }
}
