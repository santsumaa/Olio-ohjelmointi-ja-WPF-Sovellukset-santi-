using System;

namespace StaticTest
{
    class Program
    {
        static void Main(string[] args)
        {
            float kilometri = 60f; // Luodaan muuttuja kilometri 

            float mailit = StaattinenLuokka.KmToMiles(kilometri); // Käytetään staattista luokkaa hyödyksi, ja muunnetaan kilometri maileiksi

            Console.WriteLine("{0}km/h on yhtäkuin {1} mailia", kilometri, mailit);
        }
    }
}
