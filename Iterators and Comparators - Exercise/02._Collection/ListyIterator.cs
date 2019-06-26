using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02._Collection
{
    class ListyIterator<T> : IEnumerable<T>
    {
        private T[] objs;
        private int index;

        public ListyIterator(T[] obj)
        {
            this.objs = obj;
            this.index = 0;
        }

        public bool Move()
        {
            if (this.index < this.objs.Length - 1)
            {
                this.index++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.objs.Length == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }

            else
            {
                Console.WriteLine(this.objs[index]);
            }
        }

        public bool HasNext()
        {
            if (this.index < this.objs.Length - 1)
            {
                return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in objs)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this.GetEnumerator();
        }
    }
}
