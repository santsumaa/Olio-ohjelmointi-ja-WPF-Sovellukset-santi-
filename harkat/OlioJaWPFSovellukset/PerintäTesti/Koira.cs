using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    // Eläimen aliluokka
    class Koira : Eläin
    {
        // Koirien instanssit
        private static int instanssit = 0;

        // Koira luokan oma konstruktori, jossa lisätään uusi instanssi kun luodaan uusi Koira
        public Koira()
        {
            instanssit++;
        }

        // staattinen Metodi, jonka avulla tulostetaan monta koiraa on olemassa.
        // Käytetään "new" avainsanaa, sillä metodi on jo olemassa Eläin luokassa
        public static new void KuinkaMonta()
        {
            Console.WriteLine("Koiria luotu " + instanssit);
        }

        // Ylikirjoitetaan Eläin -luokan Ääntele metodi
        public override void Ääntele()
        {
            Console.WriteLine("Woof");
        }
    }
}
