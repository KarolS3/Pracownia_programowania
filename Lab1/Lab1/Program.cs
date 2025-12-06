using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        private static string TrybSortowania = "alfabet";
        private static bool Odwrotnie = false;

        static void Main(string[] args)
        {
            if (args.Length > 1) TrybSortowania = args[1];
            if (args.Length > 2 && args[2] == "reverse") Odwrotnie = true;

            string sciezka = args[0];
            DirectoryInfo katalog = new DirectoryInfo(sciezka);

            if (!katalog.Exists)
            {
                Console.WriteLine("Podany katalog nie istnieje.");
                return;
            }

            WyswietlKatalog(katalog, 0);
        }

        static void WyswietlKatalog(DirectoryInfo katalog, int wciecie)
        {
            var elementy = katalog.GetFileSystemInfos().ToList();

            string trybSortowania = Program.TrybSortowania;
            bool odwrotnie = Program.Odwrotnie;

            switch (trybSortowania)
            {
                case "alfabet":
                    elementy = elementy.OrderBy(e => e.Name).ToList();
                    break;
                case "rozmiar":
                    elementy = elementy.OrderBy(e => (e is DirectoryInfo d) ? d.PoliczElementy() : ((FileInfo)e).Length).ToList();
                    break;
                case "data":
                    elementy = elementy.OrderBy(e => e.LastWriteTime).ToList();
                    break;
            }

            if (odwrotnie)
            {
                elementy.Reverse();
            }


            foreach (var element in elementy)
            {
                Console.WriteLine($"{new string(' ', wciecie)}{element.Name} | {element.GetAtrybuty()}");

                if (element is DirectoryInfo podkatalog)
                {
                    Console.WriteLine($"{new string(' ', wciecie)}(zawiera {podkatalog.PoliczElementy()} elementów)");
                    WyswietlKatalog(podkatalog, wciecie + 2);
                }
                else if (element is FileInfo plik)
                {
                    Console.WriteLine($"{new string(' ', wciecie)}Rozmiar: {plik.Length} bajtów | Ostatnia modyfikacja: {plik.LastWriteTime}");
                }
            }
        }
    }
}