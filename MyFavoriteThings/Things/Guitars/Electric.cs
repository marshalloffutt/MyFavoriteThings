using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Guitars
{
    class Electric : Guitar
    {
        public Electric(string brand, string model, string color)
            : base(brand, model, color)
        {
        }

        public void shred()
        {
            Console.WriteLine("You are Guitar George, and you know all the chords.");
        }
    }
}