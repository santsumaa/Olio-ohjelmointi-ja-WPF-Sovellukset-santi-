using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractTest
{
    // Henkilö -luokan aliluokka
    class Opiskelija : Henkilö
    {
        // Henkilö luokan abstrakti ominaisuus, joka on pakko toteuttaa Opiskelija luokassa
        public override string Nimi { get; set; }

        // Henkilö luokan abstrakti metodi, joka on pakko toteuttaa Opiskelija luokassa
        public override void Puhu()
        {
            Console.WriteLine("Opiskelija puhuu Opiskelija -luokassa, joka perii metodin abstraktista Henkilö luokasta");
        }
    }
}
