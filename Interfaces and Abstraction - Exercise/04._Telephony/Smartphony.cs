using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Telephony
{
    class Smartphony : ICallable, IBrowsable
    {
        public string BrowseWebsite(string website)
        {
            if (website.Any(x => char.IsNumber(x)))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {website}!";
        }

        public string CallNumber(string number)
        {
            if (number.Any(x => !char.IsNumber(x)))
            {
                return "Invalid number!";
            }

            return $"Calling... {number}";
        }
    }
}
