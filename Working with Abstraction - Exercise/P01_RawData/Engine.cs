using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    class Engine
    {
        private int engineSpeed;
        private int enginePower;

        public Engine(int engineSpeed, int enginePower)
        {
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
        }

        public int EngineSpeed { get => this.engineSpeed; }

        public int EnginePower { get => this.enginePower; }
    }
}
