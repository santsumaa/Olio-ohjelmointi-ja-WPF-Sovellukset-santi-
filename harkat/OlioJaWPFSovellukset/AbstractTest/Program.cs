using System;

namespace AbstractTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija = new Opiskelija(); // luodaan uusi Opiskelija olio, joka on Henkilö luokan aliluokka
            // Ylä ja alapuoli ovat käytännössä sama asia
            Henkilö henkilöOpiskelija = new Opiskelija(); // luodaan uusi Opiskelija olio, jossa käytetään abstraktia Henkilöä

            // Henkilö henkilö = new Henkilö(); <--- Ei voida toteuttaa, sillä Henkilö luokka on abstrakti

            opiskelija.Puhu(); // Kutsutaan Puhu metodia 
            henkilöOpiskelija.Puhu(); // Kutsutaan Puhu metodia 

            Henkilö.KuinkaMonta(); // Tulostetaan henkilöiden määrä (-> 2 henkilöä, jotka ovat opiskelijoita)
        }
    }
}
