using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    // Eläimen aliluokka
    class Kissa : Eläin
    {
        // Kissojen instanssit
        private static int instanssit = 0;

        // Kissa luokan oma konstruktori, jossa lisätään uusi instanssi kun luodaan uusi Kissa
        public Kissa()
        {
            instanssit++;
        }

        // staattinen Metodi, jonka avulla tulostetaan monta Kissaa on olemassa.
        // Käytetään "new" avainsanaa, sillä metodi on jo olemassa Eläin luokassa
        public static new void KuinkaMonta()
        {
            Console.WriteLine("Kissoja luotu " + instanssit);
        }

        // Ylikirjoitetaan Eläin -luokan Ääntele metodi
        public override void Ääntele()
        {
            Console.WriteLine("Meow");
        }
    }
}
