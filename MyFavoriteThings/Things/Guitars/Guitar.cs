using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Guitars
{
    abstract class Guitar
    {
        // Properties
        public string Brand { get; protected set; }
        public string Model { get; protected set; }
        public string Color { get; protected set; }

        // Constructor
        public Guitar(string brand, string model, string color)
        {
            Brand = brand;
            Model = model;
            Color = color;
        }

        // Methods

        public void strum()
        {
            Console.WriteLine("You play the honky tonk like anything.");
        }

    }

}
