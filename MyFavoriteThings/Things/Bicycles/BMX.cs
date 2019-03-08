using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Bicycles
{
    class BMX : Bicycle
    {
        public BMX(string color)
            : base(color, false, "Slow af.")
        {
        }

        public override void Ride()
        {
            Console.WriteLine("Ride?? RIDE?!??!. You don't simply ride. You are an artist. You perform tricks.");
            BellCheck();
        }

        public void Tailwhip()
        {
            Console.WriteLine("You smash your shins with the back end of your bike. Haha.");
        }
    }
}