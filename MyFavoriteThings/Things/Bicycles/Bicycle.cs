using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Bicycles
{
    abstract class Bicycle
    {
        // Properties
        public string Color { get; protected set; }
        public bool HasBell { get; protected set; }
        public string Speed { get; protected set; }

        // Constructor
        protected Bicycle(string color, bool hasBell, string speed)
        {
            Color = color;
            HasBell = hasBell;
            Speed = speed;
        }

        // Methods
        public virtual void Ride()
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
