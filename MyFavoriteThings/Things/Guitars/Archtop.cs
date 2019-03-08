using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Guitars
{
    class Archtop : Guitar
    {
        public Archtop(string brand, string model, string color)
            : base(brand, model, color)
        {
        }

        public void playJazz()
        {
            Console.WriteLine("If peeing your pants is cool, consider me Miles Davis.");
        }
    }
}