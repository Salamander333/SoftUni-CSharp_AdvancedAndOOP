﻿using System;
using System.Collections.Generic;
using System.Text;
using _08._Military_Elite.Interfaces;

namespace _08._Military_Elite.SoldierTypes
{
    class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append($"Code Number: {this.CodeNumber}");
            return sb.ToString();
        }
    }
}
