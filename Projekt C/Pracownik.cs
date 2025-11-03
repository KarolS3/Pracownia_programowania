using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_C
{
    internal class Pracownik
    {
        public string imie {  get; private set; }
        public string nazwisko { get; private set; }
        public Stanowisko stanowisko { get; private set; }
        public double wynagrodzenie { get; private set; }
        public double staz_pracy { get; private set; }
        public Pracownik(string imie, string nazwisko, double wynagrodzenie, double staz_pracy, Stanowisko stanowisko) 
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.stanowisko = stanowisko;
            this.wynagrodzenie = wynagrodzenie;
            this.staz_pracy = staz_pracy;

        }
        public void DajPodwyzke(int size)
        {
            wynagrodzenie += size;
        }
        public void ZmienStanowisko(Stanowisko noweStanowisko)
        {
            stanowisko = noweStanowisko;
        }
        public void Pracuj( Firma f)
        {
            double wspolczynnikLosowy = Random.Next(1, 5);

        }
    }
}
