using System;
using System.Collections.Generic;
using System.Text;

namespace PoikkeustenKäsittelyEsimerkki
{
    // Exception Handler luokka hissille, täytyy periä "Exception" yliluokasta
    class HissiPoikkeusHandler : Exception
    {

        // Luodaan poikkeus, jossa tulostetaan annettu viesti  --error-- viestien väliin
        public HissiPoikkeusHandler(string message) : base(message)
        {
            Console.WriteLine("-----ERROR-----");
            Console.WriteLine(message);
            Console.WriteLine("-----ERROR-----");
        }
    }
}
