using System;
using FirmaC_;

public class MainClass
{
    static void Main(string[] args)
    {
   
        Firma f1 = new Firma();
        Firma f2 = new Firma();

        
        f1.DodajPracownika("Jan", "Kowalski", Firma.Stanowiska[0]);
        f1.DodajPracownika("Adam", "Nowak", Firma.Stanowiska[2]);

     
        f2.DodajPracownika("Anna", "Nowak", Firma.Stanowiska[1]);
        f2.DodajPracownika("Karol", "Wisniewski", Firma.Stanowiska[3]);

    
        f1.Pracuj();
        f2.Pracuj();

      
        Console.WriteLine("=== Firma 1 ===");
        Console.WriteLine(f1.ToString());

        Console.WriteLine("=== Firma 2 ===");
        Console.WriteLine(f2.ToString());

   
        Console.WriteLine("\n>>> Wynik porównania firm:");
        Console.WriteLine(Porownaj(f1, f2));
    }

 
    public static string Porownaj(Firma a, Firma b)
    {
        if (a.Wartosc > b.Wartosc)
            return "Firma A ma większą wartość.";
        else if (b.Wartosc > a.Wartosc)
            return "Firma B ma większą wartość.";
        else
            return "Obie firmy mają taką samą wartość.";
    }
}
