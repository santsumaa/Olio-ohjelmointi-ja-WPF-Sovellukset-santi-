using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_7
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
                    ErrorHelper.KirjoitaError("0001f; Virheellinen kerros annettu. Annettu arvo " + value + " on pienempi kuin " + minKerros);
                }
                else if (value > maxKerros)
                {
                    ErrorHelper.KirjoitaError("0002f; Virheellinen kerros annettu. Annettu arvo " + value + " on suurempi kuin " + maxKerros);
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
