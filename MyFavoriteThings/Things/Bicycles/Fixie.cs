using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Bicycles
{
    class Fixie : Bicycle
    {
        public Fixie(string color)
            : base(color, true, "SOOO SLOW.")
        {
        }
    }
}