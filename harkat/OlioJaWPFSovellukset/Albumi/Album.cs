using System;
using System.Collections.Generic;
using System.Text;

namespace Albumi
{
    class Album
    {
        private string Artist { get; set; }

        private string Nimi1 { get; set; }
        private string Nimi2 { get; set; }
        private string Nimi3 { get; set; }
        private string Nimi4 { get; set; }
        private string Nimi5 { get; set; }
        private string Nimi { get; set; }
        private string Genre { get; set; }
        private int Hinta { get; set; }

        private string numr { get; set; }
        private string numr2 { get; set; }
        private string numr3 { get; set; }
        private string numr4 { get; set; }
        private string numr5 { get; set; }


        public Album(string _nimi)
        {
            // Nimi alustetaan pääohjelmasta
            Artist = _nimi;

            // muut ominaisuudet alustetaan alla olevilla arvoilla
            Nimi = "Evolve";
            Genre = "pop rock";
            Hinta = 10;
            Nimi1 = "Next to me";
            Nimi2 = "i dont know why";
            Nimi3 = "whatever it takes";
            Nimi4 = "believer";
            Nimi5 = "thunder";
            numr = "3:50";
            numr2 = "3:10";
            numr3 = "3:21";
            numr4 = "3:24";
            numr5 = "3:07";
                
        }

        public void TulostaData()
        {
            Console.WriteLine("Albumi: ");
            Console.WriteLine("-- Artisti: " + Artist);
            Console.WriteLine("-- Nimi: " + Nimi);
            Console.WriteLine("-- Genre: " + Genre);
            Console.WriteLine("-- Hinta: " + Hinta + "e");
            Console.WriteLine("Songs: ");
            Console.WriteLine("-- Nimi: " + Nimi1 + " - " + numr);
            Console.WriteLine("-- Nimi: " + Nimi2 + " - " + numr2);
            Console.WriteLine("-- Nimi: " + Nimi3 + " - " + numr3);
            Console.WriteLine("-- Nimi: " + Nimi4 + " - " + numr4);
            Console.WriteLine("-- Nimi: " + Nimi5 + " - " + numr5);
            Console.ReadLine();
        }     
    }
}
