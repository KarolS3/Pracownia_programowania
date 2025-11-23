using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaC_
{

    public class Pracownik
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public Stanowisko Stanowisko { get; private set; }
        public double Wynagrodzenie { get; private set; }
        public int StazPracy { get; private set; }

        private static Random rnd = new Random();

        public Pracownik(string imie, string nazwisko, Stanowisko stanowisko, double wynagrodzenie, int stazPracy)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Stanowisko = stanowisko;
            Wynagrodzenie = wynagrodzenie;
            StazPracy = stazPracy;
        }

        public void DajPodwyzke(int size)
        {
            Wynagrodzenie += size;
        }

        public void ZmienStanowisko(Stanowisko stanowisko)
        {
            Stanowisko = stanowisko;
        }


        public void Pracuj(Firma f)
        {
            double wartosc = StazPracy * 100 * Stanowisko.wspolczynnik * rnd.Next(1, 4);
            f.ZwiekszWartosc(wartosc);
        }


    }
}
    
