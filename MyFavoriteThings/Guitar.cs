using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Guitar
    {
        // Properties
        public string Brand { get; }
        public string Model { get; }
        public GuitarType Type { get; }

        // Constructor
        public Guitar(string brand, string model, GuitarType type)
        {
            Brand = brand;
            Model = model;
            Type = type;
        }

        // Methods
        public void shred()
        {
            if (Type == GuitarType.electric)
            {
                Console.WriteLine("You are Guitar George, and you know all the chords.");
            }
            else
            {
                Console.WriteLine("You are no sultan of swing.");
            }
        }

        public void strum()
        {
            Console.WriteLine("You play the honky tonk like anything.");
        }


    }

    enum GuitarType { acoustic, electric }
}
