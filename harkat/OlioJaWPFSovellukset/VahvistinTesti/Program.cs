using System;

namespace VahvistinTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            int uusiVoimakkuus;

            Console.WriteLine("Luodaan uusi vahvistin..");
            Vahvistin vahvistin = new Vahvistin();
            Console.WriteLine("Uusi vahvistin luotu, poistu kirjoittamalla 'sammuta'");

            while (true)
            {
                Console.WriteLine("Anna uusi äänenvoimakkuus vahvistimelle (0-100) > ");
                string luettuArvo = Console.ReadLine();

                if (luettuArvo.Equals("sammuta"))
                {
                    break; //poistutatan loopista
                }

                bool result = int.TryParse(luettuArvo, out uusiVoimakkuus);

                if (result) // jos result == true
                {
                    vahvistin.Äänenvoimakkuus = uusiVoimakkuus;
                }
                else
                {
                    Console.WriteLine("Error: Annettu arvo on virheellinen! Mikäli haluat sammuttaa vahvistimen kirjoita 'sammuta'");
                }
            }

            Console.WriteLine("Vahvistin on sammutettu");
        }
    }
}
