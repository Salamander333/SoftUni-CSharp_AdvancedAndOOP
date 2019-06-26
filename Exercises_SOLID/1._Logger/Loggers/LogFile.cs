using _1._Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._Logger.Loggers
{
    class LogFile : ILogFile
    {
        public int Size { get; protected set; }

        public void Write(string message)
        {
            this.Size += message.Where(char.IsLetter).Sum(x => x);
        }
    }
}
