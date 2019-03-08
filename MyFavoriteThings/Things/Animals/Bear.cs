using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Animals
{
    class Bear : Animal
    {
        public Bear()
            : base(AnimalType.Mammal, 4, false)
        {
        }

        public override void DefenseMechanism()
        {
            Console.WriteLine("Watch Revenant to see what the bear does.");
            Eat();
        }

        public void Eat()
        {
            Console.WriteLine("The bear eats you whole.");
        }
    }
}