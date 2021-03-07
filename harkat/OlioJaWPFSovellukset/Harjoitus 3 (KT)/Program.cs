using System;

namespace Harjoitus_3__KT_
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas("Harvia");

            kiuas.TulostaData();

            kiuas.MuutaLämpötilaa(70);

            kiuas.KiuasOnOff(true);
            kiuas.MuutaLämpötilaa(70);
            kiuas.MuutaKosteutta(90);

            kiuas.TulostaData();

            kiuas.KiuasOnOff(false);
        }
    }
}
