using System;
using System.Collections.Generic;
using System.Text;

namespace Testi
{
    class TestiLuokka
    {
        public string Nimi { get; set; } // Ominaisuus

        // Konstruktori
        public TestiLuokka(string _nimi) // <-- sulkujen sisällä on parametri
        {
            // asetetaan nimeksi annettu parametri
            Nimi = _nimi;
        }


        // Metodi joka on toisen luokan sisällä, jossa ei ole parametria tai palautettavaa
        // Alla olevia metodeja kutsutaan olion/instanssin kautta
        public void Toiminto()
        {
            // Koodia..
        }

        // Metodi, jossa on yksi parametri, tyyppiä int, joka pitää antaa kun metodia kutsutaan
        public void ToimintoParametri(int i)
        {
            // Koodia..
        }

        // Metodi, jossa ei ole parametria, mutta metodin tulee palauttaa kutsujalle "int" arvo
        public int ToimintoPalautus()
        {
            // Koodia..
            // pitää palauttaa integer luku
            return 1; //Esimerkiksi integer 1
        }
    }
}
