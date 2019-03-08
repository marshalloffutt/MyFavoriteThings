using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.MortalKombatCharacters
{
    class Scorpion : Character
    {
        public Scorpion()
            : base("Scorpion", Gender.Male, true)
        {
        }

        public void Spear()
        {
            Console.WriteLine("Get Over Here!");
            UpperCut();
        }

        public void Teleport()
        {
            Console.WriteLine("Surprise!!!");
            Punch();
        }

        public void ScorpionFatality()
        {
            Console.WriteLine("Scorpion takes off his mask, to reveal that he is a skeleton person. And then sets you on fire.");
        }
    }
}