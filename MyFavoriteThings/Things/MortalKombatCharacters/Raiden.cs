using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.MortalKombatCharacters
{
    class Raiden : Character
    {
        public Raiden()
            : base("Raiden", Gender.Male, false)
        {
        }

        public void LightningBolt()
        {
            Console.WriteLine("Take 3 to the dome.");
        }

        public void Torpedo()
        {
            Console.WriteLine("You just got torpedoed!");
        }

        public void RaidenFatality()
        {
            Console.WriteLine("Raiden electocutes you.");
        }
    }
}