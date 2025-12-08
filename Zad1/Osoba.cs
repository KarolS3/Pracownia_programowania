using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    internal class Osoba
    {
        private int id;
        private string imie;
        public static int IloscInstancji = 0;

        public Osoba()
        {
            this.id = 0;
            this.imie = "";
            IloscInstancji++;
        }

        public Osoba(int id, string imie) 
        {
            this.id = id;
            this.imie = imie;
            IloscInstancji++;
        }

        public Osoba(Osoba inna)
        {
            this.id = inna.id;
            this.imie = inna.imie;
            IloscInstancji++;
        }

        public void Przywitaj(string inneimie)
        {
            if (this.imie == string.Empty) 
            {
                Console.WriteLine("Brak danych");
            }
            else
            {
                Console.WriteLine($"Cześć{inneimie}, mam na imię {this.imie}");
            }
        }
    }
}
