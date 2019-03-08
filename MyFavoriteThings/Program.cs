using System;
using MyFavoriteThings.Things.Animals;
using MyFavoriteThings.Things.Guitars;
using MyFavoriteThings.Things.Bicycles;
using MyFavoriteThings.Things.MortalKombatCharacters;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBike = new BMX("Red");
            myBike.Ride();
            myBike.Tailwhip();

            var myGuitar = new Electric("Gibson", "ES-335", "Black");
            myGuitar.shred();
            myGuitar.strum();

            var myAnimal = new Octopus();
            myAnimal.DefenseMechanism();

            var myCharacter = new LiuKang();
            myCharacter.Fireball();
            myCharacter.FlyingKick();
            myCharacter.LiuKangFatality();


            Console.ReadKey();
        }
    }
}
