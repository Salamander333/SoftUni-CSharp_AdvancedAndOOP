using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Strategy_Pattern
{
    class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.Length.CompareTo(y.Name.Length) != 0)
            {
                return x.Name.Length.CompareTo(y.Name.Length);
            }

            return x.Name.ToLower().CompareTo(y.Name.ToLower());
        }
    }
}
