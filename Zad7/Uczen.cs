using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    internal class Uczen
    {
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public int Osiagniecia { get; set; }
        public int Zachowanie { get; set; }
        public int JezykPolski { get; set; }
        public int Matematyka { get; set; }
        public int Biologia { get; set; }
        public int Geografia { get; set; }
        public int GHP {  get; set; }
        public int GHH { get; set; }
        public int GMM { get; set; }
        public int GMP { get; set; }
        public int GJP { get; set; }

        public Uczen(string line)
        {
            var arr = line.Split(';');
            Nazwisko = arr[0];
            Imie = arr[1];
            Osiagniecia = int.Parse(arr[2]);
            Zachowanie = int.Parse(arr[3]);
            JezykPolski = int.Parse(arr[4]);
            Matematyka = int.Parse(arr[5]);
            Biologia = int.Parse(arr[6]);
            Geografia = int.Parse(arr[7]);
            GHP = int.Parse(arr[8]);
            GHH = int.Parse(arr[9]);
            GMM = int.Parse(arr[10]);
            GMP = int.Parse(arr[11]);
            GJP = int.Parse(arr[12]);
        }

        public double Srednia
        {
            get => (JezykPolski + Matematyka + Biologia + Geografia) / 4d;
        }
        public double OcenyNaPunkty(int ocena)
        {
            switch (ocena)
            {
                case 3: return 4;
                case 4: return 6;
                case 5: return 8;
                case 6: return 10;
            }
            return 0;
        }
        public double LiczbaPunktow
        {
            get
            {
                var res = ((GHP + GHH + GMM + GMP + GJP) / 10d) + OcenyNaPunkty(JezykPolski) + OcenyNaPunkty(Matematyka) + OcenyNaPunkty(Biologia) + OcenyNaPunkty(Geografia) + Osiagniecia + Zachowanie == 6 ? 2d : 0d;
                return res;
            }
        }
  
        public override string ToString()
        {
            return $"{Nazwisko} {Imie} {LiczbaPunktow}";
        }
    }
}
