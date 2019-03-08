using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things.Guitars
{
    class Acoustic : Guitar
    {
        public Acoustic(string brand, string model, string color)
            : base(brand, model, color)
        {
        }

        public void playFolk()
        {
            Console.WriteLine("Good thing you've got a daytime job.");
        }
    }
}