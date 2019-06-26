using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Generic_Count_Method_Double
{
    class Box<T> where T : IComparable<T>
    {
        public Box(List<T> values)
        {
            Values = values;
        }

        public List<T> Values { get; set; }

        public int GreaterElementCount(T element)
        {
            int counter = 0;

            foreach (var item in Values)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
