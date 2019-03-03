using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBike = new Bicycle("Red", true);

            myBike.Ride();
            myBike.BellCheck();

            var myGuitar = new Guitar("Gibson", "ES-335", GuitarType.electric);

            myGuitar.shred();
            myGuitar.strum();


            Console.ReadKey();
        }
    }
}
