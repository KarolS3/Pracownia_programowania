using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaC_
{
    public class Firma
    {
        private List<Pracownik> pracownicy = new List<Pracownik>();
        public static Stanowisko[] Stanowiska = new Stanowisko[]
        {
            new Stanowisko("Junior", 1.0),
            new Stanowisko("Mid", 1.5),
            new Stanowisko("Senior", 2.0),
            new Stanowisko("Manager", 3.0)
        };
        public int Wielkosc => pracownicy.Count;
        public double Wartosc { get; private set; }
        public void DodajPracownika(string imie, string nazwisko, Stanowisko stanowisko)
        {
            pracownicy.Add(new Pracownik(imie, nazwisko, stanowisko, 3000, 100));
        }
        public void ZwolnijPracownika(string imie_nazwisko)
        {
            pracownicy.RemoveAll(p => (p.Imie + " " + p.Nazwisko) == imie_nazwisko);
        }
        public void Pracuj()
        {
            foreach (var p in pracownicy)
                p.Pracuj(this);
        }
        public void ZwiekszWartosc(double val)
        {
            Wartosc += val;
        }
        public override string ToString()
        {
            string wynik = $"Firma – liczba pracowników: {Wielkosc}, wartość: {Wartosc}\n";

            foreach (var p in pracownicy)
                wynik += $"{p.Imie} {p.Nazwisko} – {p.Stanowisko.nazwa}\n";

            return wynik;
        }
    }
}

