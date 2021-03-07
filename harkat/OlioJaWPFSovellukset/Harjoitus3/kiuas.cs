using System;
using System.Collections.Generic;
using System.Text;

namespace kiuas
{
    class kiuas
    {
        public string Tila { get; set; }

        public int LämpTila { get; set; }

        public int Kosteus { get; set; }


        public string HaeTiedot()
        {
            string KiuasJuu = "Tila:" + Tila + " Lämpötila:" + LämpTila + " Kosteus:" + Kosteus.ToString();

            return KiuasJuu;
        }
    }
}