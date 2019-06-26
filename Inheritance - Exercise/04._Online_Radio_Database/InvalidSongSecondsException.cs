using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Online_Radio_Database
{
    class InvalidSongSecondsException : Exception
    {
        public InvalidSongSecondsException(string message = "Song seconds should be between 0 and 59.") : base(message)
        {
        }
    }
}
