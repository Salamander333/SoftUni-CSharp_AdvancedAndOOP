﻿namespace _03BarracksFactory.Models.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using _03BarracksFactory.Contracts;

    class FightCommand : Command
    {
        public FightCommand(string[] data) 
            : base(data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return null;
        }
    }
}
