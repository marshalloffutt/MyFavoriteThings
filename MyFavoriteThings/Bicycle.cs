using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Bicycle
    {
        // Properties
        public string Color { get; }
        public bool HasBell { get; }

        // Constructor
        public Bicycle(string color, bool hasBell)
        {
            Color = color;
            HasBell = hasBell;
        }

        // Methods
        public void Ride()
        {
            Console.WriteLine("You ride your bike around the block.");
        }

        public void BellCheck()
        {
            if (HasBell)
            {
                Console.WriteLine("You ring the bell, because why not.");
            }
            else
            {
                Console.WriteLine("You crash your bike into a ditch. Good job.");
            }
        }
    }
}
