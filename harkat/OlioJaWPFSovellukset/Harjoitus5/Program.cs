using System;

namespace laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 5.0f;
            float b = 2.5f;

            float summa = Laskin.Summa(a, b);
            float erotus = Laskin.Erotus(a, b);
            float jako = Laskin.Jako(a, b);
            float kerto = Laskin.Kerto(a, b);

            Console.WriteLine("Numeroiden {0} ja {1}:", a, b);
            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Erotus: " + erotus);
            Console.WriteLine("jako: " + jako);
            Console.WriteLine("kerto: " + kerto);

        }
    }
}
