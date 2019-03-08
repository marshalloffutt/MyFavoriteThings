using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.MortalKombatCharacters
{
    abstract class Character
    {
        public string Name { get; protected set; }
        public Gender Gender { get; protected set; }
        public bool IsFunToPlayAs { get; protected set; }

        protected Character(string name, Gender gender, bool isFunToPlayAs)
        {
            Name = name;
            Gender = gender;
            IsFunToPlayAs = isFunToPlayAs;
        }

        public void Punch()
        {
            Console.WriteLine("You just got punched.");
        }

        public void UpperCut()
        {
            Console.WriteLine("You just got uppercut!!");
        }

        public void Kick()
        {
            Console.WriteLine("You just got kicked.");
        }

    }

    internal enum Gender
    {
        Male,
        Female,
        Other
    }

}