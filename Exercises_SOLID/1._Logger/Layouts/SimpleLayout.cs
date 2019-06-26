using System;
using System.Collections.Generic;
using System.Text;
using _1._Logger.Interfaces;

namespace _1._Logger.Layouts
{
    class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
    }
}
