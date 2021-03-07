using System;

namespace hissi
{
    class Program
    {
        static void Main(string[] args)
        {
            int Uuskerros;

            hissi hsi = new hissi();

            while (true)
            {
                Console.WriteLine("Anna uusi kerros (1-6)");
                string luettuArvo = Console.ReadLine();

                if (luettuArvo.Equals("sammuta"))
                {
                    break; //poistutatan loopista
                }

                bool result = int.TryParse(luettuArvo, out Uuskerros);

                if (result) // jos result == true
                {
                    hsi.Hissikerros = Uuskerros;
                }
                else
                {
                    Console.WriteLine("Error: Annettu arvo on virheellinen!");
                }
            }

        }
    }
}