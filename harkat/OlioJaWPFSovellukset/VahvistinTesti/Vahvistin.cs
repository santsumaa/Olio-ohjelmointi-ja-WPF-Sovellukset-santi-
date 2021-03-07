using System;
using System.Collections.Generic;
using System.Text;

namespace VahvistinTesti
{
    class Vahvistin
    {
        private int äänenvoimakkuus;

        public int Äänenvoimakkuus
        {
            get => äänenvoimakkuus;
            set
            {
                // Kun äänenvoimakuutta muutetaan, käydään ensin allaoleva koodi läpi

                if (value > 100)
                {
                    Console.WriteLine("Annettu arvo oli suurempi kuin 100");
                    value = 100;
                }
                else if (value < 0)
                {
                    Console.WriteLine("Annettu arvo oli pienempi kuin 0");
                    value = 0;
                }

                Console.WriteLine("Äänenvoimakkuus asetettu, uusi arvo on " + value);

                äänenvoimakkuus = value;
            }
        }
    }
}
