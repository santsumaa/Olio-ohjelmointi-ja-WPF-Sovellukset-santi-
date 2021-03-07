using System;

namespace kiuas
{
    class Program
    {
        static void Main(string[] args)
        {
            kiuas KiuasOlio = new kiuas();

            KiuasOlio.Tila = "päällä";
            KiuasOlio.LämpTila = 75;
            KiuasOlio.Kosteus = 2;
            Console.WriteLine(KiuasOlio.HaeTiedot());
        }
    }
}