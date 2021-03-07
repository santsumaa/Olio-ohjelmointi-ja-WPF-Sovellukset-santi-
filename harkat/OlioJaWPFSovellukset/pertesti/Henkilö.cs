
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{

    // abstrakti Henkilö luokka. Luokat jotka ovat merkitty Abstract avainsanalla, ei voida luoda olioita
    abstract class Henkilö
    {
        // abstrakti ominaisuus, joka täytyy toteuttaa aliluokissa
        public abstract string Nimi { get; set; }

        // Henkilön Instanssit, jonka avulla voidaan laskea henkilö -olioiden määrä
        private static int instanssit = 0;

        // Henkilö luokan konstruktori, jossa lisätään instanssit muuttujaan + 1 kun uusi Henkilö olio luodaan
        public Henkilö()
        {
            instanssit++;
        }

        // Staattinen metodi, jossa tulostetaan olemassa olevien Henkilö -olioiden / instanssien määrän
        public static void KuinkaMonta()
        {
            Console.WriteLine("Henkilöitä on olemassa: " + instanssit);
        }

        // Abstrakti metodi, joka täytyy toteuttaa aliluokissa (abstraktin metodin sisälle ei tule koodia)
        public abstract void Puhu();
    }
}