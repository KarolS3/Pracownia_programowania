namespace Zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("punkty_rekrutacyjne.txt");
            var uczniowie = new List<Uczen>();
            for (var i = 1; i < lines.Length; i++)
            {
                var uczen = new Uczen(lines[i]);
                uczniowie.Add(uczen);
            }

            foreach (var uczen in uczniowie)
            {
                Console.WriteLine(uczen);
            }

            //Zadanie 1
            Console.WriteLine("Zadanie 1");
            var zestawienie1 = uczniowie.Where(x => x.Osiagniecia == 0 && x.Zachowanie >= 5 && x.Srednia > 4)
                .OrderBy(x => x.Nazwisko).Take(5);
            foreach (var zestawienie in zestawienie1)
            {
                Console.WriteLine(zestawienie);
            }

            //Zadanie 2
            Console.WriteLine("Zadanie 2");

        }
    }
}
