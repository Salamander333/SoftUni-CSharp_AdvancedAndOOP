using System;
using System.Collections.Generic;
using System.Text;
using _08._Military_Elite.SoldierTypes;

namespace _08._Military_Elite.Interfaces
{
    interface ILieutenantGeneral
    {
        List<ISoldier> Privates { get; }
    }
}
