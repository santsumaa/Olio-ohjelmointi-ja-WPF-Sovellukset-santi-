using System;

namespace Testi
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // Muuttuja (Variable)

            TestiLuokka testiOlio = new TestiLuokka("testiArvo"); // Luodaan uusi olio/instanssi TestiLuokka -luokasta

            testiOlio.Toiminto(); // <-- Käytetään TestiLuokka -luokan metodia
        }

        // Metodi, joka on pääohjelmassa
        public void TeeLasku()
        {

        }
    }
}
