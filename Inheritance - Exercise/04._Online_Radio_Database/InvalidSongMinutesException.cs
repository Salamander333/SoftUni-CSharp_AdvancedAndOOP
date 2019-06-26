using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Online_Radio_Database
{
    class InvalidSongMinutesException : Exception
    {
        public InvalidSongMinutesException(string message = "Song minutes should be between 0 and 14.") : base(message)
        {
        }
    }
}
