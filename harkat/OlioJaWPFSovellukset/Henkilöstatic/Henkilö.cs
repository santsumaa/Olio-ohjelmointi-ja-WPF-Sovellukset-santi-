using System;
using System.Collections.Generic;
using System.Text;

namespace HenkilöStatic
{

    // Normaali luokka, jonka sisällä on staattisia jäseniä
    class Henkilö
    {
        // Henkilön Instanssit, jonka avulla voidaan laskea henkilö -olioiden määrä
        private static int instanssit = 0;

        // Henkilö luokan konstruktori, jossa lisätään instanssit muuttujaan + 1 kun uusi Henkilö olio luodaan
        public Henkilö()
        {
            instanssit++;
        }

        // Staattinen metodi, jossa tulostetaan olemassa olevien Henkilö -olioiden / instanssien määrän
        public static void KuinkaMontaHenkilöä()
        {
            Console.WriteLine("Henkilöitä olemassa: " + instanssit);
        }
    }
}
