using System;

namespace Harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Olio Ajoneuvo -luokasta
            Ajoneuvo auto = new Ajoneuvo();

            // Asetetaan oliolle "auto" arvot
            auto.Nimi = "Toyota";
            auto.Nopeus = 160;
            auto.Renkaat = 4;

            // Käytetään "auto" olion toimintoja
            auto.TulostaData();

            // Noudetaan auton tiedot ToString() metodilla
            string autonTiedot = auto.ToString();
            Console.WriteLine(autonTiedot);

            // Tyhjä rivi konsoliin
            Console.WriteLine();

            // Luodaan toinen olio luokasta Ajoneuvo

            Ajoneuvo mopo = new Ajoneuvo();
            mopo.Nimi = "Skootteri";
            mopo.Nopeus = 55;
            mopo.Renkaat = 2;

            mopo.TulostaData();
            Console.Write(mopo.ToString());
        }
    }
}
