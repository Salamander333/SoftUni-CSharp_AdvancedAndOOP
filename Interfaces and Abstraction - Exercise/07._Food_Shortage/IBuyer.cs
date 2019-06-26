using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Food_Shortage
{
    interface IBuyer
    {
        string Name { get; }

        int Food { get; }

        void BuyFood();
    }
}
