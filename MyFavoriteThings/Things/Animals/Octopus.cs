using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Animals
{
    class Octopus : Animal
    {
        public Octopus()
            : base(AnimalType.Other, 8, false)
        {
        }

        public override void DefenseMechanism()
        {
            Console.WriteLine("Sprays you with ink!!");
        }
    }
}