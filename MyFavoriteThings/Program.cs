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

            Console.ReadKey();
        }
    }
}
