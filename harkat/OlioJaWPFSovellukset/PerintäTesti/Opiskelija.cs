using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    // Opiskelija luokka, joka on Luokan Henkilö aliluokka (child class)
    class Opiskelija : Henkilö
    {
        // Opiskelija luokan oma ominaisuus (ei ole yhteyksissä Henkilö -luokkaan)
        public string OpiskelijaID { get; set; }

        // Opiskelija luokan metodi Puhu(), joka on ylikirjoitettu "Henkilö" luokasta
        public override void Puhu()
        {
            Console.WriteLine(Nimi + " puhui Opiskelija luokassa");
        }
    }
}
