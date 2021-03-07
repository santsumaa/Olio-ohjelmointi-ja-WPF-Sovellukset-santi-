using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    // Henkilö -luokka, joka toimii Opiskelijan yliluokkana (parent class)
    class Henkilö
    {
        // Henkilön ominaisuudet, jotka peritytyvät aliluokille (eli "lapsille")
        public string Nimi { get; set; }
        public int Ikä { get; set; }

        // Virtuaalinen metodi, joka voidaan ylikirjoittaa (override) aliluokissa
        public virtual void Puhu()
        {
            Console.WriteLine(Nimi + " puhui henkilö luokassa");
        }
    }
}
