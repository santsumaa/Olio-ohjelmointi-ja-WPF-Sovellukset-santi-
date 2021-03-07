using System;
using System.Collections.Generic;
using System.Text;

namespace hissi
{
    class hissi
    {
        private int hissikerros;

        public int Hissikerros
        {
            get => Hissikerros;
            set
            {
                // Kun äänenvoimakuutta muutetaan, käydään ensin allaoleva koodi läpi

                if (value > 6)
                {
                    Console.WriteLine("olet nyt kerroksessa: ");
                    value = 5;
                }
                else if (value < 1)
                {
                    Console.WriteLine("error virheellinen kerros");
                    value = 0;
                }

                Console.WriteLine("olet nyt kerroksessa " + value);

                hissikerros = value;
            }
        }
    }
}