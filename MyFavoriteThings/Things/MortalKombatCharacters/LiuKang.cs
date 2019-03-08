using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.MortalKombatCharacters
{
    class LiuKang : Character
    {
        public LiuKang()
            : base("LiuKang", Gender.Male, true)
        {
        }

        public void Fireball()
        {
            Console.WriteLine("FIREBALL!!");
        }

        public void FlyingKick()
        {
            Console.WriteLine("Flying kick!");
            Kick();
        }

        public void LiuKangFatality()
        {
            Console.WriteLine("Cartwheel uppercut!!");
            UpperCut();
        }
    }
}