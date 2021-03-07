using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    // Eläin -luokka, joka toimii Koira ja Kissa luokkien yliluokkana (parent class)
    class Eläin
    {
        // Henkilön ominaisuus, jotka peritytyvät aliluokille (eli "lapsille")
        public string Nimi { get; set; }

        // Eläimen Instanssit, jonka avulla voidaan laskea eläinten määrä (yliluokka + kaikkien aliluokkien summa)
        // Eli, jos luodaan Koira -olio, tulee Eläin -luokan instanssiin myös + 1
        private static int instanssit = 0;

        // Eläin luokan konstruktori, jossa lisätään instanssit muuttujaan + 1 kun uusi Eläin olio luodaan
        public Eläin()
        {
            instanssit++;
        }

        // Staattinen metodi, joka tulostaa kuinka monta eläintä on yhteensä elossa 
        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä luotu " + instanssit);
        }

        // Virtuaalinen metodi, joka voidaan ylikirjoittaa aliluokissa
        public virtual void Ääntele()
        {
            Console.Write("Eläin Ääntelee");
        }
    }
}
