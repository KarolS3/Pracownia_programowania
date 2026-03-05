using System;

namespace Wzorce_Projektowe
{
    /// <summary>
    /// Abstrakcyjna fabryka aut
    /// </summary>

    // - - - - - - - - - - - poczatek kodu ucznia - - - - -

    // ===== INTERFEJSY POJAZDÓW =====

    public interface ISUV
    {
        void jestemDuzy();
    }

    public interface ISedan
    {
        void jestemMaly();
        void ZlotSedanow(ISedan drugiSedan);
    }

    public interface IKombi
    {
        void jestemSredni();
    }

    // ===== INTERFEJS FABRYKI =====

    public interface IFabrykaAut
    {
        ISUV CreateSUV();
        ISedan CreateSedan();
        IKombi CreateKombi();
    }

    // ===== CZERWONE AUTA =====

    public class CzerwonySUV : ISUV
    {
        public void jestemDuzy()
        {
            Console.WriteLine("Jestem duzy czerwony SUV");
        }
    }

    public class CzerwonySedan : ISedan
    {
        public void jestemMaly()
        {
            Console.WriteLine("Jestem maly czerwony Sedan");
        }

        public void ZlotSedanow(ISedan drugiSedan)
        {
            Console.WriteLine("Czerwony sedan spotkal sie z innym sedanem");
            drugiSedan.jestemMaly();
        }
    }

    public class CzerwoneKombi : IKombi
    {
        public void jestemSredni()
        {
            Console.WriteLine("Jestem srednie czerwone Kombi");
        }
    }

    // ===== NIEBIESKIE AUTA =====

    public class NiebieskiSUV : ISUV
    {
        public void jestemDuzy()
        {
            Console.WriteLine("Jestem duzy niebieski SUV");
        }
    }

    public class NiebieskiSedan : ISedan
    {
        public void jestemMaly()
        {
            Console.WriteLine("Jestem maly niebieski Sedan");
        }

        public void ZlotSedanow(ISedan drugiSedan)
        {
            Console.WriteLine("Niebieski sedan spotkal sie z innym sedanem");
            drugiSedan.jestemMaly();
        }
    }

    public class NiebieskieKombi : IKombi
    {
        public void jestemSredni()
        {
            Console.WriteLine("Jestem srednie niebieskie Kombi");
        }
    }

    // ===== FABRYKI =====

    public class FabrykaCzerwonych : IFabrykaAut
    {
        public ISUV CreateSUV()
        {
            return new CzerwonySUV();
        }

        public ISedan CreateSedan()
        {
            return new CzerwonySedan();
        }

        public IKombi CreateKombi()
        {
            return new CzerwoneKombi();
        }
    }

    public class FabrykaNiebieskich : IFabrykaAut
    {
        public ISUV CreateSUV()
        {
            return new NiebieskiSUV();
        }

        public ISedan CreateSedan()
        {
            return new NiebieskiSedan();
        }

        public IKombi CreateKombi()
        {
            return new NiebieskieKombi();
        }
    }

    // - - - - - - - - - koniec kodu ucznia - - - - - -


    class Fabryka_Abstrakcyjna
    {
        public static void Main()
        {
            Console.WriteLine("Otwieramy fabryki!");
            Console.WriteLine("Fabryka czerwonych");

            var fabrykaCzerwonych = new FabrykaCzerwonych();
            var fabrykaNiebieskich = new FabrykaNiebieskich();

            OtworzFabrykeAut(fabrykaCzerwonych);

            Console.WriteLine("------");
            Console.WriteLine("Fabryka niebieskich");

            OtworzFabrykeAut(fabrykaNiebieskich);

            Console.WriteLine("------");
            Console.WriteLine("A teraz mamy zlot sedanow:");

            zlot(fabrykaNiebieskich, fabrykaCzerwonych);
        }

        public static void OtworzFabrykeAut(IFabrykaAut fabryka)
        {
            var sedan = fabryka.CreateSedan();
            var kombi = fabryka.CreateKombi();
            var suv = fabryka.CreateSUV();

            sedan.jestemMaly();
            kombi.jestemSredni();
            suv.jestemDuzy();
        }

        public static void zlot(IFabrykaAut fabryka1, IFabrykaAut fabryka2)
        {
            var sedan1 = fabryka1.CreateSedan();
            var sedan2 = fabryka2.CreateSedan();

            sedan1.ZlotSedanow(sedan2);
        }
    }
}