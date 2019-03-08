using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Bicycles
{
    class RoadBike : Bicycle
    {
        public RoadBike(string color)
            : base(color, false, "Zoom zoom.")
        {
        }

        public void Race()
        {
            Console.WriteLine("He's racing and pacing and plotting the course.");
        }

    }
}