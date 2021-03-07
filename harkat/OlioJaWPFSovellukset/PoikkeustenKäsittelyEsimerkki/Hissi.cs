using System;
using System.Collections.Generic;
using System.Text;

namespace PoikkeustenKäsittelyEsimerkki
{
    class Hissi
    {
        private int kerros;

        private int minKerros;
        private int maxKerros;

        public int Kerros
        {
            set
            {
                if (value < minKerros)
                {
                    // Mikäli annettu kerros on pienempi kuin minimi sallittu kerros, heitetään uusi poikkeus
                    throw new HissiPoikkeusHandler("0001f; Virheellinen kerros annettu. Annettu arvo " + value + " on pienempi kuin " + minKerros);                 
                }
                else if (value > maxKerros)
                {
                    // Mikäli annettu kerros on suurempi kuin maksimi sallittu kerros, heitetään uusi poikkeus
                    throw new HissiPoikkeusHandler("0002f; Virheellinen kerros annettu. Annettu arvo " + value + " on suurempi kuin " + maxKerros);
                }
                else
                {
                    kerros = value;
                }
            }
        }

        public Hissi(int _minKerros, int _maxKerros)
        {
            minKerros = _minKerros;
            maxKerros = _maxKerros;

            kerros = minKerros;
        }

        public void TulostaNykyinenKerros()
        {
            Console.WriteLine("Nykyinen kerros on " + kerros);
        }

        public string PalautaMinMax()
        {
            return minKerros.ToString() + "-" + maxKerros.ToString();
        }
    }
}
