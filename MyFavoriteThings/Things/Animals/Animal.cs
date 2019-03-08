using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Animals
{
    abstract class Animal
    {
        public AnimalType AnimalType { get; protected set; }
        public bool HasWings { get; protected set; }
        public int NumberOfLegs { get; protected set; }

        protected Animal(AnimalType animalType, int numberOfLegs, bool hasWings)
        {
            NumberOfLegs = numberOfLegs;
            AnimalType = animalType;
            HasWings = hasWings;
        }

        public virtual void DefenseMechanism()
        {
            Console.WriteLine("Runs away");
        }

    }


    internal enum AnimalType
    {
        Fish,
        Amphibian,
        Reptile,
        Bird,
        Mammal,
        Other
    }
}