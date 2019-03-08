using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Animals
{
    class Penguin : Animal
    {
        public Penguin()
            : base(AnimalType.Bird, 2, true)
        {
        }

        public override void DefenseMechanism()
        {
            Console.WriteLine("Performs encantation to summon Goragaroth, the emperor of Emperor Penguins.");
        }

        public void Splash()
        {
            Console.WriteLine("Splashes you with water.");
        }
    }
}