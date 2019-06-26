using System;
using System.Collections.Generic;
using System.Text;

namespace P03_JediGalaxy
{
    class Entity
    {
        public Entity(int r, int c)
        {
            Row = r;
            Col = c;
        }

        public int Row { get; set; }

        public int Col { get; set; }
    }
}
