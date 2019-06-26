using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Strategy_Pattern
{
    class AgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
