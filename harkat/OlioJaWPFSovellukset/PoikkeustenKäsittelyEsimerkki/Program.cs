using System;

namespace PoikkeustenKäsittelyEsimerkki
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(1, 6);

            int uusiKerros;
            string lukija;

            Console.WriteLine("Tervetuloa hissiin. Poistu hissistä kirjoittamalla 'poistu'");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Anna uusi kerros ({0}) < ", hissi.PalautaMinMax());

                lukija = Console.ReadLine();

                if (lukija.Equals("poistu"))
                    break;

                // Luodaan Try catch lohkot, jossa tehdään tarkistukset poikkeuksia varten
                try
                {
                    bool tarkistus = int.TryParse(lukija, out uusiKerros);

                    if (tarkistus) // tarkistus == true
                    {
                        hissi.Kerros = uusiKerros;
                    }
                    else
                    {
                        // jos käyttäjä on antanut virheellisen syötön, esimerkiksi kirjaimia, heitetään uusi poikkeus
                        throw new HissiPoikkeusHandler("0003f; Virheellinen syöttö!Kokeile uudestaan.");
                    }
                }
                catch (HissiPoikkeusHandler)
                {
                    // Tyhjä, koska HissiPoikkeusHandler luokassa tulostetaan heitetty virhe viesti
                }

                hissi.TulostaNykyinenKerros();
            }

            Console.WriteLine("Poistuttiin hissistä");
        }
    }
}
