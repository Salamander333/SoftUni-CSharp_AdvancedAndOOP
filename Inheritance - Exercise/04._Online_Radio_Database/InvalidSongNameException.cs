using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Online_Radio_Database
{
    class InvalidSongNameException : Exception
    {
        public InvalidSongNameException(string message = "Song name should be between 3 and 30 symbols.") : base(message)
        {
        }
    }
}
