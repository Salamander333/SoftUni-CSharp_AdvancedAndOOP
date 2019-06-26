using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Online_Radio_Database
{
    class InvalidArtistNameException : Exception
    {
        public InvalidArtistNameException(string message = "Artist name should be between 3 and 20 symbols.") : base(message)
        {
        }
    }
}
