using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Date_Modifier
{
    public class DateModifier
    {
        public double FindDifference(string date_1, string date_2)
        {
            DateTime firstDate = DateTime.Parse(date_1);
            DateTime secondDate = DateTime.Parse(date_2);

            return Math.Abs((firstDate - secondDate).TotalDays);
        }

    }
}
