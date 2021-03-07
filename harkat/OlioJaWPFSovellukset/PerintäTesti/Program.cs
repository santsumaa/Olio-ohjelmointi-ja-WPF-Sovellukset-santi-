using System;

namespace PerintäTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            // perintä testin ensimmäinen osio
            Henkilö henkilö = new Henkilö(); // Luodaan Henkilö "Matti"
            henkilö.Nimi = "Matti";

            henkilö.Puhu();  // Kutsutaan Henkilö -luokan metodia Puhu()

            Opiskelija opiskelija = new Opiskelija();  // Luodaan Opiskelija "Pekka", joka on Henkilö-luokan aliluokka
            opiskelija.Nimi = "Pekka";

            opiskelija.Puhu(); // Kutsutaan Opiskelija -aliluokan metodia Puhu()

            // perintä testin toinen osio
            Eläin.KuinkaMonta();  // Kutsutaan staattista metodia "KuinkaMonta" Eläin -luokasta. --> Eläimiä olemassa 0

            Koira koira1 = new Koira(); // Luodaan uusi Koira olio, joka on Eläin -luokan aliluokka
            koira1.Ääntele(); // kutsutaan Koira -luokan "Ääntele" metodia --> "Woof"

            Kissa kissa1 = new Kissa(); // Luodaan uusi Kissa olio, joka on Eläin -luokan aliluokka
            kissa1.Ääntele(); // kutsutaan Kissa -luokan "Ääntele" metodia --> "Meow"

            Eläin.KuinkaMonta(); // Kutsutaan staattista metodia "KuinkaMonta" Eläin -luokasta. --> Eläimiä olemassa 2

            Koira koira2 = new Koira(); // Luodaan uusi Koira olio
            Koira koira3 = new Koira(); // Luodaan uusi Koira olio
            Kissa kissa2 = new Kissa(); // Luodaan uusi Koira olio

            Koira.KuinkaMonta(); // Kutsutaan staattista metodia "KuinkaMonta" Koira -luokasta. --> Koiria olemassa 3
            Kissa.KuinkaMonta(); // Kutsutaan staattista metodia "KuinkaMonta" Kissa -luokasta. --> Kissoja olemassa 2
            Eläin.KuinkaMonta(); // Kutsutaan staattista metodia "KuinkaMonta" Eläin -luokasta. --> Eläimiä olemassa 5
        }
    }
}
