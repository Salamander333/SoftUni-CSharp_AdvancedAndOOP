﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04._Froggy
{
    class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.stones[i];
                }
            }

            for (int i = this.stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 1)
                {
                    yield return this.stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this.GetEnumerator();
        }
    }
}
