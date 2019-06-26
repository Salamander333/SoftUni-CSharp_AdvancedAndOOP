using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Raw_Data
{
    public class Engine
    {
        private int engineSpeed;
        private int enginePower;

        public int EngineSpeed
        {
            get { return engineSpeed; }
        }

        public int EnginePower
        {
            get { return enginePower; }
        }

        public Engine(int engineSpeed, int enginePower)
        {
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
        }
    }
}
