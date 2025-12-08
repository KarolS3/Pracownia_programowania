namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba();
            o1.Przywitaj("Jan");
            Osoba o2 = new Osoba(1, "Kasia");
            o2.Przywitaj("Marek");
           

            int[] liczby = new int[10];
            Random generator = new Random();

            for (int i = 0; i < liczby.Length; i++) 
            {
                liczby[i] = generator.Next(0, 1000);
            }

            Console.WriteLine("Nieposortowane:");
            foreach (int x in liczby)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            Sortowanie sorter = new Sortowanie();
            sorter.BubbleSort(liczby);
            Console.WriteLine("Posortowane rosnąco:");
            foreach (int x in liczby)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
       
    }
}
