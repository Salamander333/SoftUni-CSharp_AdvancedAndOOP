using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03._Stack
{
    class Stacky<T> : IEnumerable<T>
    {

        private List<T> items;

        public Stacky()
        {
            items = new List<T>();
        }

        public void Push(T[] items)
        {
            this.items.AddRange(items);
        }

        public void Pop()
        {
            if (this.items.Count == 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                this.items.RemoveAt(this.items.Count - 1);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.items.Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
