using System;

namespace HenkilöStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö.KuinkaMontaHenkilöä(); // Haetaan Henkilö luokan staattista metodia, joka tulostaa henkilö -olioiden määrän --> 0

            Henkilö henkilö1 = new Henkilö(); // luodaan uusi Henkilö -olio

            Henkilö.KuinkaMontaHenkilöä(); // Haetaan Henkilö luokan staattista metodia, joka tulostaa henkilö -olioiden määrän --> 1

            // Luodaan useita henkilö olioita
            Henkilö henkilö2 = new Henkilö(); 
            Henkilö henkilö3 = new Henkilö();
            Henkilö henkilö4 = new Henkilö();
            Henkilö henkilö5 = new Henkilö();
            Henkilö henkilö6 = new Henkilö();

            Henkilö.KuinkaMontaHenkilöä(); // Haetaan Henkilö luokan staattista metodia, joka tulostaa henkilö -olioiden määrän --> 6
        }
    }
}
