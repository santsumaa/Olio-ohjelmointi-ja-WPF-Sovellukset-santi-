using System;

namespace Amplifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int newVolume;
            Console.WriteLine("Luodaan uutta vahvistinta..");
            Amplifier vahvistin = new Amplifier();
            Console.WriteLine("Vahvistin luotu, poistu kirjoittamalla 'sammuta'");

            while (true)
            {
                Console.WriteLine("Anna uusi äänenvoimakkuus vahvistimelle(0-100) > ");
                string line = Console.ReadLine();

                if (line.Equals("sammuta"))
                    break;

                bool result = int.TryParse(line, out newVolume);

                if (result)
                {
                    vahvistin.Volume = int.Parse(line);
                    Console.WriteLine("Vahvistimen arvo on asetettu: " + vahvistin.Volume);
                }
                else
                {
                    Console.WriteLine("Virheellinen arvo annettu! Kirjoita 'sammuta', mikäli haluat lopettaa");
                }

            }

            Console.WriteLine("Vahvistin sammutettu");
        }
    }
}
