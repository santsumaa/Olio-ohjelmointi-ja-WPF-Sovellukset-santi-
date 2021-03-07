using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTest
{
    // Staattinen luokka "static" avainsanalla
    static class StaattinenLuokka
    {
        // staattinen metodi, jonka avulla voidaan muuntaa kilometrit maileiksi.
        //Metodissa tulee olla yksi parametri (float i) ja tulee palauttaa float -arvo hakijalle
        public static float KmToMiles(float i)
        {
            float conversion = 0.62137f;

            return i * conversion;
        }
    }
}
