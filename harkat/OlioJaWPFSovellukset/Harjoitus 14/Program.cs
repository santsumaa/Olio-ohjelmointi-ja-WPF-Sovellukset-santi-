using System;
using System.IO;

namespace Harjoitus_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string lukija;
            string filePath = @"d:\harjoitus14.txt";

            try
            {
                //// Tämä kirjoittaisi ja lukisi tiedostoa tietokoneen MyDocuments kansiosta
                //string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine("Muistiinpanot: ");
                    }
                }

                bool poistutaanko = false;

                while (!poistutaanko)
                {
                    Console.WriteLine("---------------------------------------------------------------------------------------");
                    Console.WriteLine("Anna komento (Lisää, Näytä, Poista, Poistu) > ");
                    lukija = Console.ReadLine().ToLower();

                    switch (lukija)
                    {
                        case "lisää":
                            LisääMuistiinpano(filePath);
                            break;
                        case "näytä":
                            NäytäMuistiinpanot(filePath);
                            break;
                        case "poista":
                            PoistaMuistiinpanot(filePath);
                            break;
                        case "poistu":
                            poistutaanko = true;
                            return;
                        default:
                            Console.WriteLine("Annettu komento on virheellinen, anna uusi komento!");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void LisääMuistiinpano(string filePath)
        {
            string lukija = "";

            Console.WriteLine("Kirjoita uusi muistiinpano: ");
            Console.WriteLine();
            lukija = Console.ReadLine();

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(lukija);
            }
        }

        static void PoistaMuistiinpanot(string filePath)
        {
            // Korvataan tiedosto uudella pohjalla, joka sisältää vain "Muistiinpanot:" rivin
            File.WriteAllText(filePath, "Muistiinpanot: ");
        }

        static void NäytäMuistiinpanot(string filePath)
        {
            Console.WriteLine();
            string[] rivit = File.ReadAllLines(filePath);

            foreach (string rivi in rivit)
            {
                Console.WriteLine(rivi);
            }
        }
    }
}
